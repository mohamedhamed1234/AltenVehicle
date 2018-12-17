using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AltenVehiclesMonitor.Models;
using AltenVehiclesMonitor.ApiCaller;

namespace AltenVehiclesMonitor.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            RestApiCaller restApi = new RestApiCaller();
            var vm = await restApi.VehiclesAsync();
            return View(vm);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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