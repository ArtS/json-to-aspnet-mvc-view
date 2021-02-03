using json_to_view.Entities;
using json_to_view.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace json_to_view.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private string GetDateString(DateTime date)
        {
            return date.ToShortDateString();
        }

        public IActionResult Index()
        {
            var model = new HomeModel
            {
                Customers = new List<Customer> {
                    new Customer { Id = 1, FirstName = "Hasim", LastName = "Santello", DOB = GetDateString(new DateTime(2004, 9, 2))},
                    new Customer { Id = 2, FirstName = "Inger", LastName = "Zupone", DOB = GetDateString(new DateTime(1938, 5, 21))},
                    new Customer { Id = 3, FirstName = "Derrick", LastName = "Have", DOB = GetDateString(new DateTime(2014, 3, 29))},
                    new Customer { Id = 4, FirstName = "Atalanta", LastName = "Jeakins", DOB = GetDateString(new DateTime(1922, 5, 13))},
                    new Customer { Id = 5, FirstName = "Mahmoud", LastName = "Rudolph", DOB = GetDateString(new DateTime(1973, 5, 9))}
                }
            };
            return View(model);
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
