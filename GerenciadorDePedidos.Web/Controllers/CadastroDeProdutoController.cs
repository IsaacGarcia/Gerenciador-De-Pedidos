﻿using GerenciadorDePedidos.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDePedidos.Web.Controllers
{
    public class CadastroDeProdutoController : BaseController
    {
        
        //
        // GET: /CadastroDeProduto/

        public ActionResult Logout(Usuario usuario)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();
            Session["Statusdousuario"] = "Logoff";
            return Redirect("/Login");
        }

        public ActionResult Edit(int Id)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();
            
            Produto produto = db.Produtoes.Find(Id);
            
            return View(produto);
        }

        [HttpPost]
        public ActionResult Edit(Produto produto)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();
            if (ModelState.IsValid)
            {
                db.Entry(produto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        public ActionResult Salvar(Produto produto)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();
            
            db.Produtoes.Add(produto);
            db.SaveChanges();

            return Redirect("/CadastroDeProduto");
        }

        public ActionResult Remover(int Id)
        {
             GerenciadorDePedidosWebContext context = new GerenciadorDePedidosWebContext();

            try
            {
                var produto = context.Produtoes.SingleOrDefault(x => x.Id == Id);

                context.Produtoes.Remove(produto);

                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {               
                this.ViewBag.Produtos = context.Produtoes.Select(x => x);   

                return View("Erro");
            }
        }

        public ActionResult Index()
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            this.ViewBag.Produtos = db.Produtoes.Select(x => x);            

            return View();
        }
    }
}