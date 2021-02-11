using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
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
            List<string> restaurantList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                restaurantList.Add(string.Format("#{0}: {1} Favorite dish: {2} Address: {3}", r.Rank, r.Name, r.FavDish, r.Address));
            }

            return View(restaurantList);
        }
        //Everything should work here. Absolutely no clue why it doesn't. The code is identical to Assignment 3, which works.
        [HttpPost]
        public IActionResult SuggestionList(Addition submissions)
        {
            TempStorage.AddSubmission(submissions);
            return View("Confirmation", submissions);
        }

        public IActionResult Suggestions()
        {
            return View();
        }

        public IActionResult SuggestionList()
        {
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
