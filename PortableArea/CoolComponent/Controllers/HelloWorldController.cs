using System.Web.Mvc;

namespace PortableArea.CoolComponent.Controllers
{
	public class HelloWorldController : Controller
	{
		public ViewResult Index()
		{
			return View();
		}
	}
}