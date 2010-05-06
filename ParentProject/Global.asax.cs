using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcContrib.PortableAreas;
using MvcContrib.Routing;

namespace ParentProject
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"Default", // Route name
				"{controller}/{action}/{id}", // URL with parameters
				new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
			);

		}

protected void Application_Start()
{
	// This registers areas, both in-project and portable
	AreaRegistration.RegisterAllAreas();

	// This ensures the views embedded in the Portable Area can be found
	PortableAreaRegistration.RegisterEmbeddedViewEngine();

	// Typical MVC route registration call
	RegisterRoutes(RouteTable.Routes);
}
	}
}