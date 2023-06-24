using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = new List<Product>();
            products.Add(new Product() { Title = "Manzara Tablosu", OldPrice = 75, IsSale = true, ImageUrl = "https://picsum.photos/id/236/450/300", StarCount = 3, Price = 50 });
            products.Add(new Product() { Title = "Hayvan Tablosu", OldPrice = 75, IsSale = true, ImageUrl = "https://picsum.photos/id/237/450/300", StarCount = 5, Price = 50 });
            products.Add(new Product() { Title = "Şehir Tablosu", OldPrice = 75, IsSale = false, ImageUrl = "https://picsum.photos/id/238/450/300", StarCount = 4, Price = 50 });
            products.Add(new Product() { Title = "Bitki Tablosu", OldPrice = 75, IsSale = true, ImageUrl = "https://picsum.photos/id/239/450/300", StarCount = 3, Price = 50 });
            products.Add(new Product() { Title = "Merdiven Tablosu", OldPrice = 75, IsSale = true, ImageUrl = "https://picsum.photos/id/240/450/300", StarCount = 2, Price = 50 });
            products.Add(new Product() { Title = "Tepe Tablosu", OldPrice = 75, IsSale = true, ImageUrl = "https://picsum.photos/id/241/450/300", StarCount = 5, Price = 50 });
            products.Add(new Product() { Title = "Tren Rayı Tablosu", OldPrice = 75, IsSale = true, ImageUrl = "https://picsum.photos/id/242/450/300", StarCount = 4, Price = 50 });
            products.Add(new Product() { Title = "Orman Tablosu", OldPrice = 75, IsSale = true, ImageUrl = "https://picsum.photos/id/243/450/300", StarCount = 4, Price = 50 });
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}