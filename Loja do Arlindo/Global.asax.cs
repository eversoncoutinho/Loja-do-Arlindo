using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Loja_do_Arlindo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start() //roda assim que a aplica��o � carregada
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes); //a RouteTable � criada em tempo de execu��o. 
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
