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
        
        
        //
        // GET: /Cliente/
        public ActionResult Index()
        {

            ViewBag.coco = 1;

            return View();
        }
	}
}