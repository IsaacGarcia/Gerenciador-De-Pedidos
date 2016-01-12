using GerenciadorDePedidos.Web.Models;
using GerenciadorDePedidos.Web.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDePedidos.Web.Controllers
{
    public class PedidosFiltroController : Controller
    {

        public ActionResult Filtrar(PedidosViewModel model)
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            if ((model.valorMaximo.HasValue) && (model.valorMinimo.HasValue) && (model.mesMinimo.HasValue) && (model.mesMaximo.HasValue))
            {
                ViewBag.Valor = db.Pedidoes.Where(x => x.Valortotal >= model.valorMinimo && x.Valortotal <= model.valorMaximo && x.Mes >= model.mesMinimo && x.Mes <= model.mesMaximo);
            }
            else
            {
                return HttpNotFound();
            }

            //if ((model.diaMaximo.HasValue) && (model.diaMinimo.HasValue))
            //{
            //   ViewBag.Dia = db.Pedidoes.Where(x => x.Valortotal >= model.valorMinimo && x.Valortotal <= model.valorMaximo);                  
            //}

            //if (model.NomeCliente != null)
            //{
            //    ViewBag.Nome = db.Pedidoes.Where(x => x.Cliente.Nome == model.NomeCliente);
            //}


            ViewBag.Pedidos = ViewBag.Valor;

            ViewBag.Clientes = db.Clientes.Select(x => x);
            
            return View();
        }

        //
        // GET: /PedidosFiltro/
        public ActionResult Index()
        {

            return View();
        }
	}
}