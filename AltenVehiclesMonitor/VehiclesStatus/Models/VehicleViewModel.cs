using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using VehiclesStatus.DataAccessLayer;

namespace VehiclesStatus.Models
{
    public class VehicleViewModel
    {
        public int Id { get; set; }

        public string VehicleId { get; set; }

        public string RegNo { get; set; }

        public string Status { get; set; }

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        /// <summary>
        /// return List of vehicles view model
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<VehicleViewModel> Vehicles(string id)
        {

            
            List<VehicleViewModel> cvs = new List<VehicleViewModel>();

            try
            {
                DataRow[] results = VehicleRepository.loadData(id);
                Random rnd = new Random();
                string status = "";

                foreach (DataRow item in results)
                {
                    //generate Random Number to simulate vehicle status
                    int number = rnd.Next(2);

                    if (number == 0)
                    {
                        status = "Disconnected";
                    }
                    else
                    {
                        status = "Connected";
                    }

                    cvs.Add(new VehicleViewModel
                    {
                        Id = int.Parse(item["Id"].ToString()),
                        VehicleId = item["VehicleId"].ToString(),
                        RegNo = item["RegNo"].ToString(),
                        Status = status,// item["Status"].ToString(),
                        CustomerId = int.Parse(item["CustomerId"].ToString()),
                        CustomerName = item["CustomerName"].ToString(),
                        CustomerAddress = item["CustomerAddress"].ToString()
                    });
                }
            }

            catch(Exception ex)
            {
                
                cvs.Add(new VehicleViewModel
                {
                    Id = int.Parse("0"),
                    VehicleId = "0",
                    RegNo = "0",
                    Status = "0",//item["Status"].ToString(),
                    CustomerId = int.Parse("0"),
                    CustomerName = "0",
                    CustomerAddress = ex.Message
                });
            }
                return cvs;
            
        }

    }
}
