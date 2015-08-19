using GerenciadorDePedidos.Web.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDePedidos.Web.Controllers
{
    [SecuritySessionFilter]
    public class BaseController : Controller
    {
 
	}
}