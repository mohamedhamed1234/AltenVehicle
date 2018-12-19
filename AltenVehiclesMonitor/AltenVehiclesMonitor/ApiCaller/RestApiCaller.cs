using AltenVehiclesMonitor.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AltenVehiclesMonitor.ApiCaller
{
    public class RestApiCaller : IRestApiCaller
    {

        private string ConnectionErr = "Unable to connect, please check your internet connection.";
        private string GeneralErr = "Error";

        private string RestUrl;
        private string _errorMsg = "";
        private bool _hasError = false;

        public bool HasError
        {
            get { return _hasError; }
        }

        public string ErrorMsg
        {
            get { return _errorMsg; }
        }

        public RestApiCaller()
        {
            RestUrl = "http://vehiclesmicroservices-dev.us-east-1.elasticbeanstalk.com";
        }
        /// <summary>
        /// call vehicles microservice and return all vehicle data
        /// </summary>
        /// <returns> List<VehicleModel> </returns>
        public async Task<List<VehicleModel>> VehiclesAsync()
        {
            string url = RestUrl + "/api/vehicles";

            List<VehicleModel> Vehicles = null;

            try
            {
                var uri = new Uri(string.Format(url, string.Empty));
                HttpClient client = new HttpClient();
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Vehicles = JsonConvert.DeserializeObject<List<VehicleModel>>(content);
                }
            }
            catch (HttpRequestException)
            {
                _errorMsg = ConnectionErr;
                _hasError = true;
            }
            catch (Exception)
            {

                _errorMsg = GeneralErr;
                _hasError = true;
            }

            return Vehicles;
        }

    }
}
