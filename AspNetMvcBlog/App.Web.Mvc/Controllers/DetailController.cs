using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
	public class DetailController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
