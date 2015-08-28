using GerenciadorDePedidos.Web.Models;
using GerenciadorDePedidos.Web.Models.Views;
using System;
using System.Collections.Generic;
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


        public ActionResult Adicionar(Produto produto, int quantidade, int total)
        {
            return Redirect("/Produtos");
        }

        public ActionResult Index()
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            CadastroDePedido pedido = new CadastroDePedido();

            ViewBag.Produtos = db.Produtoes.Select(x => x).ToList();

            return View();
        }
    }
}