using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.ViewComponents
{
    public class ProductItemViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title, int starCount, double oldPrice, double price, string imageUrl, bool isSale)
        {
            var product = new Product()
            {
                Title = title,
                StarCount = starCount,
                OldPrice = oldPrice,
                Price = price,
                ImageUrl = imageUrl,
                IsSale = isSale
            };

            return View(product);
        }
    }
}
