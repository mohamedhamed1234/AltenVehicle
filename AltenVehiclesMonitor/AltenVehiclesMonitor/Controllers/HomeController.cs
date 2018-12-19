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
        /// <summary>
        /// Home controller constructor which takes Interface of RestApiCaller
        /// </summary>
        /// <param name="restApiCaller"></param>
        public HomeController(IRestApiCaller restApiCaller)
        {
            _restApiCaller = restApiCaller;
        }
        /// <summary>
        /// index action which return list of vehicles view model 
        /// </summary>
        /// <returns>List Vehicles Model</returns>
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