using System.Web.Mvc;
using MvcContrib.PortableAreas;

namespace PortableArea.CoolComponent
{
	public class CoolComponentRegistration : PortableAreaRegistration
	{
		public override string AreaName
		{
			get { return "CoolComponent"; }
		}

		public override void RegisterArea(AreaRegistrationContext context, IApplicationBus bus)
		{
			base.RegisterArea(context, bus);

			context.MapRoute(
				"CoolComponent_Default", 
				"coolcomponent/{controller}/{action}/{id}",
				new {controller = "HelloWorld", action = "Index", id = UrlParameter.Optional });
		}
	}
}