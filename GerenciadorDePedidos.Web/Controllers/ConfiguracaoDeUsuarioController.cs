using GerenciadorDePedidos.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDePedidos.Web.Controllers
{
    public class ConfiguracaoDeUsuarioController : BaseController
    {

        public ActionResult Configurar(Usuario usuario)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            Usuario user = db.Usuarios.Where(x => x.Login == usuario.Login && x.Senha == usuario.Senha).SingleOrDefault();

            if (user == null)
            {
                return View("Index");
            }
            else
            {

                return View("Configurar", user);
            }

        }

        [HttpPost]
        public JsonResult TrocarSenha(int id, string novasenha)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            Usuario usuario = db.Usuarios.Find(id);

            usuario.TrocarSenha(novasenha);

            db.Entry(usuario).State = EntityState.Modified;

            db.SaveChanges();

            return Json(usuario);

        }

        [HttpPost]
        public JsonResult TrocarEmail(int id, string email)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            Usuario usuario = db.Usuarios.Find(id);

            usuario.TrocarEmail(email);

            db.Entry(usuario).State = EntityState.Modified;

            db.SaveChanges();

            return Json(usuario);
        }

        [HttpPost]
        public JsonResult TrocarLogin(int id, string login)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            Usuario usuario = db.Usuarios.Find(id);

            usuario.TrocarLogin(login);

            db.Entry(usuario).State = EntityState.Modified;

            db.SaveChanges();

            return Json(usuario);
        }

        //
        // GET: /ConfiguracaoDeUsuario/
        public ActionResult Index()
        {
            return View();
        }
    }
}