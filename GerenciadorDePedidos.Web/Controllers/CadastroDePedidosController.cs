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

        public ActionResult Adicionar()
        {
            return Redirect("/Produtos");
        }
        
        public ActionResult Index()
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            CadastroDePedido pedido = new CadastroDePedido();

            pedido.Produtos = db.Produtoes.Select(x => x).ToList();
            
            return View(pedido);
        }
	}
}