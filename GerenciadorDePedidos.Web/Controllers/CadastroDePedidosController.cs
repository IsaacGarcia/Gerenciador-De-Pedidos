using GerenciadorDePedidos.Web.Models;
using GerenciadorDePedidos.Web.Models.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDePedidos.Web.Controllers
{
    public class CadastroDePedidosController : BaseController
    {
        //
        // GET: /CadastroDePedidos/


        [HttpGet]
        public JsonResult ObterProdutoPeloId(int id)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            var produto = db.Produtoes.SingleOrDefault(x => x.Id == id);

            return Json(produto, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Cancelar(int IdDoItem)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            Item item = db.Items.Find(IdDoItem);

            db.Items.Remove(item);

            db.SaveChanges();

            return View();
        }

        [HttpPost]
        public ActionResult DeletarPedido(int IdDoPedido)
        {
            if (IdDoPedido == 0)
            {

                return View();

            }
            else
            {

                GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

                try
                {

                    var pedido = db.Pedidoes.SingleOrDefault(x => x.Id == IdDoPedido);

                    db.Pedidoes.Remove(pedido);

                    db.SaveChanges();

                }
                catch
                {

                    var item = db.Items.Where(x => x.IdDoPedido == IdDoPedido);

                    foreach (Item i in item)
                    {

                        db.Items.Remove(i);


                    }

                    db.SaveChanges();

                }
                finally
                {

                    db.SaveChanges();

                }

                return View();

            }
        }

        [HttpPost]
        public ActionResult BuscarCliente(string Codigo)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            var empresa = db.Clientes.SingleOrDefault(x => x.Cnpj == Codigo);

            var cliente = db.Clientes.SingleOrDefault(x => x.Cpf == Codigo);

            if (empresa != null && empresa.TipoPessoa == TipoPessoa.Juridica)
            {
                empresa.Nome = " ";

                empresa.Sobrenome = " ";

                return Json(empresa);
            }
            else if (cliente != null && cliente.TipoPessoa == TipoPessoa.Fisica)
            {
                cliente.NomeFantasia = " ";
                return Json(cliente);
            }
            else
            {
                Cliente c = new Cliente();

                c.Nome = "Não Encontrado";

                return Json(c);
            }


        }


        [HttpPost]
        public ActionResult SalvarPedido(int Dia, int Mes, int Ano, string Descricao, int PedidoId, int ClienteId)
        {
            if (PedidoId == 0)
            {
                return RedirectToAction("Index");

            }
            else
            {

                GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

                Cliente cliente = db.Clientes.Find(ClienteId);

                Pedido pedido = db.Pedidoes.Find(PedidoId);

                foreach (Item item in pedido.Itens)
                {
                    pedido.Valortotal = +item.Total;
                }

                pedido.Cliente = cliente;

                pedido.IdCliente = ClienteId;

                pedido.Dia = Dia;

                pedido.Mes = Mes;

                pedido.Ano = Ano;

                pedido.Descricao = Descricao;

                db.Entry(pedido).State = EntityState.Modified;

                db.SaveChanges();

                return Json(pedido);
            }
        }


        public ActionResult NovoPedido()
        {

            return Redirect("Index");
        }

        [HttpPost]
        public ActionResult Adicionar(int Id, int quantidade, int Pedido)
        {

            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            var produto = db.Produtoes.Find(Id);

            Item item = new Item();

            item.Quantidade = quantidade;

            item.Produto = produto;

            item.Total = item.CalcularTotal();

            //--------------------------------------------------------------------
            //    Condição que verifica se eh o primeiro item a ser adicionado e instacia um pedido para o mesmo 
            //--------------------------------------------------------------------

            if (Pedido == 0)
            {
                Pedido pedido = new Pedido();                

                pedido.Valortotal = item.Total;

                db.Pedidoes.Add(pedido);

                db.SaveChanges();

                item.IdDoPedido = pedido.Id;

                db.Items.Add(item);

                pedido.Itens.Add(item);                                

                db.Entry(pedido).State = EntityState.Modified;

                db.SaveChanges();



            }
            else
            {
                var pedido = db.Pedidoes.Find(Pedido);

                db.Items.Add(item);

                pedido.Itens.Add(item);

                pedido.Acrescenta(item.Total);

                db.Entry(pedido).State = EntityState.Modified;

                db.SaveChanges();

                item.IdDoPedido = pedido.Id;

                db.Entry(item).State = EntityState.Modified;

                db.SaveChanges();
            }

            return Json(item);
        }

        public ActionResult Index()
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            CadastroDePedido pedido = new CadastroDePedido();

            ViewBag.Produtos = db.Produtoes.Select(x => x).ToList();

            ViewBag.Itens = db.Items.Select(x => x);

            return View();
        }
    }
}