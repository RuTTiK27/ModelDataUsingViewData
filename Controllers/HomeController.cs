using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;
using System.Diagnostics;

namespace ModelDataUsingViewData.Controllers
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
            //Product product = new Product()
            //{
            //    Id = 1,
            //    Name = "Dell Mouse",
            //    Description = "Dell wireless mouse with usb 3.0",
            //    Price = 225
            //};

            //ViewData["product"] = product;
            //ViewBag.Product = product;
            //TempData["product"] = product;

            var products = new List<Product>
            {
                new Product { Id = 1,Name="Mouse",Description="Dell wireless mouse with usb 3.0",Price=225},
                new Product { Id = 2,Name="Keyboard",Description="Dell wireless keyboard with usb 3.0",Price=1025},

            };
            ViewData["products"] = products;
            //ViewBag.Products = products;
            //TempData["products"] = products;
            return View();
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
