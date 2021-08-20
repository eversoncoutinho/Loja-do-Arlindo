using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Loja_do_Arlindo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //as rotas mais complexas devem estar primeiro
            //Exemplo

            routes.MapMvcAttributeRoutes(); //ele lê todas as rotas da controller e colocará em uma coleção

            routes.MapRoute(
               name: "Teste",
               url: "Teste/{controller}/{action}/{id}",
               //É obrigatório porém não precisa ser a única
               defaults: new { controller = "Teste", action = "Indexteste", id = UrlParameter.Optional }
           );
            //Rota padrão
            //É obrigatório porém não precisa ser a única
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
