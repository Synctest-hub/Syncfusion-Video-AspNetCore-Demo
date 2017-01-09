using Microsoft.AspNetCore.Mvc;

namespace Imperugo.Syncfusion.Video.AspNetCore.Demo._006.Controllers
{
	public class HomeController : Controller
	{
		private readonly MyConfiguration configuration;

		public HomeController(MyConfiguration configuration)
		{
			this.configuration = configuration;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Error(string id)
		{
			if (id == "404")
			{
				return View("NotFound");
			}

			return View("Error");
		}

		public IActionResult Exception()
		{
			int.Parse("this is not a number");
			return View();
		}
	}
}
