using GerenciadorDePedidos.Web.Models;
using GerenciadorDePedidos.Web.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDePedidos.Web.Controllers
{
    public class GraficosController : Controller
    {

        public ActionResult CalculaMes()
        {
            GerenciadorDePedidosWebContext db = new GerenciadorDePedidosWebContext();

            var grafico = new GraficoViewModel();

            var Janeiro = db.Pedidoes.Where(x=>x.Mes == 1 && x.Ano == 2015);

            foreach (Pedido p in Janeiro){

                grafico.Janeiro = grafico.Janeiro + p.Valortotal;

            }

            var Fevereiro = db.Pedidoes.Where(x => x.Mes == 2 && x.Ano == 2015);

            foreach (Pedido p in Fevereiro)
            {

                grafico.Fevereiro = grafico.Fevereiro + p.Valortotal;

            }

            var Marco = db.Pedidoes.Where(x => x.Mes == 3 && x.Ano == 2015);

            foreach (Pedido p in Marco)
            {

                grafico.Marco = grafico.Marco + p.Valortotal;

            }

            var Abril = db.Pedidoes.Where(x => x.Mes == 4 && x.Ano == 2015);

            foreach (Pedido p in Abril)
            {

                grafico.Abril = grafico.Abril + p.Valortotal;

            }


            var Maio = db.Pedidoes.Where(x => x.Mes == 5 && x.Ano == 2015);

            foreach (Pedido p in Maio)
            {

                grafico.Maio = grafico.Maio + p.Valortotal;

            }


            var Junho = db.Pedidoes.Where(x => x.Mes == 6 && x.Ano == 2015);

            foreach (Pedido p in Junho)
            {

                grafico.Junho = grafico.Junho + p.Valortotal;

            }

            var Julho = db.Pedidoes.Where(x => x.Mes == 7 && x.Ano == 2015);

            foreach (Pedido p in Julho)
            {

                grafico.Julho = grafico.Julho + p.Valortotal;

            }

            var Agosto = db.Pedidoes.Where(x => x.Mes == 8 && x.Ano == 2015);

            foreach (Pedido p in Agosto)
            {

                grafico.Agosto = grafico.Agosto + p.Valortotal;

            }

            var Setembro = db.Pedidoes.Where(x => x.Mes == 9 && x.Ano == 2015);

            foreach (Pedido p in Setembro)
            {

                grafico.Setembro = grafico.Setembro + p.Valortotal;

            }

            var Outubro = db.Pedidoes.Where(x => x.Mes == 10 && x.Ano == 2015);

            foreach (Pedido p in Outubro)
            {

                grafico.Outubro = grafico.Outubro + p.Valortotal;

            }

            var Novembro = db.Pedidoes.Where(x => x.Mes == 11 && x.Ano == 2015);

            foreach (Pedido p in Novembro)
            {

                grafico.Novembro = grafico.Novembro + p.Valortotal;

            }

            var Dezembro = db.Pedidoes.Where(x => x.Mes == 12 && x.Ano == 2015);

            foreach (Pedido p in Dezembro)
            {

                grafico.Dezembro = grafico.Dezembro + p.Valortotal;

            }



            return View(grafico);
        }


        //
        // GET: /Graficos/
        public ActionResult Index()
        {
            return View();
        }
    }
}