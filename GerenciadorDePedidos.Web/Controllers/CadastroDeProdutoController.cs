using GerenciadorDePedidos.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDePedidos.Web.Controllers
{
    public class CadastroDeProdutoController : Controller
    {
        //
        // GET: /CadastroDeProduto/
        public ActionResult Salvar(Produto produto)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            db.Produtoes.Add(produto);
            db.SaveChanges(); ;

            return Redirect("/CadastroDeProduto");
        }

        public ActionResult Index()
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();
            
            this.ViewBag.Produtos = db.Produtoes.Select(x => x);

            return View();
        }
    }
}