using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDePedidos.Web.Filters
{
    public class SecuritySessionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["SegurancaAtiva"]))
            {
                if (!UsuarioEstaLogado(filterContext))
                    filterContext.Result = new RedirectToRouteResult(ObterRota());

                base.OnActionExecuting(filterContext);
            }
        }

        private static bool UsuarioEstaLogado(ActionExecutingContext filterContext)
        {

            if (filterContext.HttpContext.Session["UsuarioLogado"] != null)
            {
                return (bool)filterContext.HttpContext.Session["UsuarioLogado"];
            }
            else
            {
                return false;
            }
        }

        private static System.Web.Routing.RouteValueDictionary ObterRota()
        {
            return new System.Web.Routing.RouteValueDictionary { { "Controller", "Login" }, { "Action", "Index" } };
        }
    }
}