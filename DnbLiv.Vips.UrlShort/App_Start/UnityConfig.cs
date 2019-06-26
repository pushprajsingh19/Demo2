using DnbLife.Vips.BussinessLayer;
using DnbLiv.Vips.DataAccessLayer;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace DnbLiv.Vips.UrlShort
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IVipsDataAccess, VipsDataAccess>();
            container.RegisterType<IShortUrlManager, ShortUrlManager>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}