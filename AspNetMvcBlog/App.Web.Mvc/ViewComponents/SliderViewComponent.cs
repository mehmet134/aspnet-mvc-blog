using App.Web.Mvc.Data;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.ViewComponents
{
	public class SliderViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var database = new Database();
			var sliderList = database.SliderList;

			return View(sliderList);
		}
	}
}
