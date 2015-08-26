using GerenciadorDePedidos.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDePedidos.Web.Controllers
{
    public class ClienteController : BaseController
    {

        public ActionResult Cadastrar (Cliente cliente)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            db.Clientes.Add(cliente);
            db.SaveChanges();

            return View("Index");
        }
        //
        // GET: /Cliente/
        public ActionResult Index()
        {
                        
            return View();
        }
	}
}