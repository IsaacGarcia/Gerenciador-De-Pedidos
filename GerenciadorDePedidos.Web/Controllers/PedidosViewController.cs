using GerenciadorDePedidos.Web.Models;
using GerenciadorDePedidos.Web.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDePedidos.Web.Controllers
{
    public class PedidosViewController : BaseController
    {


        public ActionResult Detais(int pedidoId)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            var pedido = db.Pedidoes.Find(pedidoId);

            ViewBag.Cliente = db.Clientes.Where(x => x.Id == pedido.IdCliente);

            ViewBag.Itens = db.Items.Where(x => x.IdDoPedido == pedidoId);

            ViewBag.Produto = db.Produtoes.Select(x => x);

            return View(pedido);
        }

        public ActionResult Delete(int id)
        {

            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            var pedido = db.Pedidoes.Find(id);

            if (pedido == null)
            {

                return HttpNotFound();

            }

            ViewBag.Cliente = db.Clientes.Where(x => x.Id == pedido.IdCliente);

            ViewBag.Itens = db.Items.Where(x => x.IdDoPedido == id);

            ViewBag.Produto = db.Produtoes.Select(x => x);

            return View(pedido);

        }


        public ActionResult DeletarConfirmado(int id)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            var item = db.Items.Where(x => x.IdDoPedido == id);


                if (item == null)
                {

                    var pedido = db.Pedidoes.SingleOrDefault(x => x.Id == id);

                    db.Pedidoes.Remove(pedido);

                    db.SaveChanges();

                }
                else
                {

                    foreach (Item i in item)
                    {

                        db.Items.Remove(i);

                    }

                    db.SaveChanges();

                    var pedido = db.Pedidoes.SingleOrDefault(x => x.Id == id);

                    db.Pedidoes.Remove(pedido);

                    db.SaveChanges();

                }
            

            return RedirectToAction("Index");

        }

        public ActionResult NovoPedido()
        {

            return Redirect("/CadastroDePedidos/Index");
        }


        //
        // GET: /PedidosView/
        public ActionResult Index()
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            var pedido = db.Pedidoes.Select(x => x);

            ViewBag.Pedidos = pedido;

            var cliente = db.Clientes.Select(x => x);

            ViewBag.Clientes = cliente;

            return View();
        }
    }
}