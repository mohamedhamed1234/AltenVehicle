using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerVehicles.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerVehicles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerVehiclesController : ControllerBase
    {
        /// <summary>
        /// gets customer vehicles by customer id
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        [HttpGet("{CustomerId}")]
        public IEnumerable<VehicleViewModel> Get(string customerId)
        {
            var vm = VehicleViewModel.Vehicles(customerId);
            return vm.ToList();
        }
    }
}