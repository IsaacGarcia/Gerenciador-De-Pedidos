using GerenciadorDePedidos.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDePedidos.Web.Controllers
{
    public class UsuariosController : Controller
    {
        public ActionResult Salvar (Usuario usuario) 
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            db.Usuarios.Add(usuario);
            db.SaveChanges();

            return View("Index");
        }
        //
        // GET: /Usuarios/
        public ActionResult Index()
        {
            return View();
        }
	}
}