using GerenciadorDePedidos.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDePedidos.Web.Controllers
{
    public class VisualizaProdutosController : BaseController
    {
        //
        // GET: /VisualizaProdutos/
        public ActionResult Index()
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();
            var Produtos = db.Produtoes.Select(x => x);
            ViewBag.Produtos = Produtos;

            return View();
        }
	}
}