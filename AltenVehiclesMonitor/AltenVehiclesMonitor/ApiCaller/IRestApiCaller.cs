using AltenVehiclesMonitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltenVehiclesMonitor.ApiCaller
{
    public interface IRestApiCaller
    {
        
        Task<List<VehicleModel>> VehiclesAsync();
    }
}
