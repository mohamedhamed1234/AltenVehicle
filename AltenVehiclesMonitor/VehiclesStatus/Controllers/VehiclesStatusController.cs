using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehiclesStatus.Models;

namespace VehiclesStatus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesStatusController : ControllerBase
    {
        /// <summary>
        /// gets vehicle data and status by vehicle id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IEnumerable<VehicleViewModel> Get(string id)
        {
            var vm = VehicleViewModel.Vehicles(id);
            return vm.ToList();
        }
    }
}