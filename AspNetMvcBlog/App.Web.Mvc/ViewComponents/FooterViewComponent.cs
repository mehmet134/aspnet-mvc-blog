using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FooterModel model3 = this.GetFooterData();

            return View(model3);
        }

        private FooterModel GetFooterData()
        {
            return new FooterModel();
        }
    }
}
