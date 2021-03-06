﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehiclesMicroservices.DataAccessLayer;
using VehiclesMicroservices.Models;

namespace AltenVehiclesMonitor.Controllers
{
    [Route("api/[controller]")]
    //[EnableCors("AllowAllOrigins")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        /// <summary>
        /// gets all vehicles data
        /// </summary>
        /// <returns></returns>
        public IEnumerable<VehicleViewModel> Get()
        {          
            var vm = VehicleViewModel.Vehicles;
            return vm.ToList();
        }
    }
}