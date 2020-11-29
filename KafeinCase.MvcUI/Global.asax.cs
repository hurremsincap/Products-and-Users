using System;
using System.Threading;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using KafeinCase.Business.DependencyResolvers.Ninject;
using KafeinCase.Core.Utilities.MVC.Infrastructure;
using System.Web;
using KafeinCase.Core.CrossCuttingConcerns.Security.Web;
using KafeinCase.Core.CrossCuttingConcerns.Security;

namespace KafeinCase.MvcUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BusinessModule()));
        }       

    }
}
