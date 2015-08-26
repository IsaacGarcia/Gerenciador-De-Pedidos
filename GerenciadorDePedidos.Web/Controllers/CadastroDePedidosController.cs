using GerenciadorDePedidos.Web.Models;
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


            return View();
        }
	}
}