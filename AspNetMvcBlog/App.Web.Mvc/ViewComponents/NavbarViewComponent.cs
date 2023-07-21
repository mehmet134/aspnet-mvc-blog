using App.Web.Mvc.Data;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.ViewComponents
{
	public class NavbarViewComponent : ViewComponent
	{

	   public async Task<IViewComponentResult> InvokeAsync()
		{
			var database = new Database();
			var ustList = database.UstList;

			return View(ustList);
		}
	}
}
