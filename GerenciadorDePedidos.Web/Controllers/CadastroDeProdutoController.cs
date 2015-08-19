﻿using GerenciadorDePedidos.Web.Models;
using System;
using System.Collections.Generic;
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
            ControleDePedidosContext db = new ControleDePedidosContext();
            Session["Statusdousuario"] = "Logoff";
            return Redirect("/Login");
        }
        
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