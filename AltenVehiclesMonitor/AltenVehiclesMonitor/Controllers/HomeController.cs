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
        private readonly IRestApiCaller _restApiCaller;

        public HomeController(IRestApiCaller restApiCaller)
        {
            _restApiCaller = restApiCaller;
        }

        public async Task<IActionResult> Index()
        {
            //RestApiCaller restApi = new RestApiCaller();
            var vm = await _restApiCaller.VehiclesAsync();
            return View(vm);
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}