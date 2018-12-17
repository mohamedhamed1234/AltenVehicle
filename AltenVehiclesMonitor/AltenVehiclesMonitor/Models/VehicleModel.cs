using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltenVehiclesMonitor.Models
{
    public class VehicleModel
    {

        public int Id { get; set; }

        public string VehicleId { get; set; }

        public string RegNo { get; set; }

        public string Status { get; set; }

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }
    }
}
