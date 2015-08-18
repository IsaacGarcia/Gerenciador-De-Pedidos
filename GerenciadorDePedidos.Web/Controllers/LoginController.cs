using GerenciadorDePedidos.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDePedidos.Web.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Logar(Usuario usuario)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();
            
            Usuario user = db.Usuarios.Where(x => x.Login == usuario.Login && x.Senha ==  usuario.Senha).SingleOrDefault();

            if (user == null)
            {
                return Redirect("/Login");
            }
            else
            {
                return Redirect("/CadastroDeUsuario");
            }
            
        }
        public ActionResult Index()
        {
            return View();
        }
	}
}