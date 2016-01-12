using GerenciadorDePedidos.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDePedidos.Web.Controllers
{
    public class ClienteController : BaseController
    {

        public ActionResult Cadastrar(Cliente cliente)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            db.Clientes.Add(cliente);
            db.SaveChanges();

            return Redirect("/Cliente");
        }

        public ActionResult MostrarClientes()
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            ViewBag.Clientes = db.Clientes.Select(x => x).ToList();

            return View();
        }

        [HttpGet]
        public ActionResult BuscarPorNome(string Nome)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            ViewBag.Cliente = db.Clientes.Where(x => x.Nome == Nome || x.Cpf == Nome || x.Email == Nome || x.Telefone == Nome || x.Sobrenome == Nome);

            return View();
            
        }

        [HttpGet]
        public ActionResult BuscarPorCodigo(string Cpf)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            var cliente = db.Clientes.Where(x => x.Cpf == Cpf);

            ViewBag.Cliente = cliente;

            return View();

        }

        [HttpGet]
        public ActionResult BuscarPorTelefone(string Telefone)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            ViewBag.Cliente = db.Clientes.Where(x => x.Telefone == Telefone);

            return View();

        }

        [HttpGet]
        public ActionResult BuscarPorNomeFantasia(string NomeFantasia)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            ViewBag.Cliente = db.Clientes.Where(x => x.NomeFantasia == NomeFantasia || x.RazaoSocial == NomeFantasia || x.Cnpj == NomeFantasia || x.Email == NomeFantasia || x.Telefone == NomeFantasia);

            return View();

        }

        [HttpGet]
        public ActionResult BuscarPorCnpj(string Cnpj)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            ViewBag.Cliente = db.Clientes.Where(x => x.Cnpj == Cnpj);

            return View();

        }

        public ActionResult Edit(int Id)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            Cliente cliente = db.Clientes.Find(Id);

            return View(cliente);
        }

        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();
            if (ModelState.IsValid)
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", cliente);
            }

            return RedirectToAction("MostrarClientes");
        }

        public ActionResult Details(int Id)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            Cliente cliente = db.Clientes.Find(Id);

            return View(cliente);
        }

        public ActionResult Delete(int Id)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            var cliente = db.Clientes.SingleOrDefault(x => x.Id == Id);

            db.Clientes.Remove(cliente);

            db.SaveChanges();

            return Redirect("/Cliente/MostrarClientes");
        }

        //
        // GET: /Cliente/
        public ActionResult Index()
        {

            return View();
        }
    }
}