using App.Web.Mvc.Data;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        Database database = new Database();
        public IActionResult Index(int? id,string search)
        {
            var analists = database.AnaList.ToList();
            if (id.HasValue)
            {
                analists = database.AnaList.Where(p =>p.Id == id).ToList();
            }
            if(search != null)
            {
				analists = database.AnaList.Where(p => p.Name.ToLower().Contains(search.ToLower())).ToList();


			}
			return View(analists);
        }
    }
}
