using AltenVehiclesMonitor.ApiCaller;
using AltenVehiclesMonitor.Controllers;
using AltenVehiclesMonitor.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace AltenVehiclesMonitorTests
{
    public class HomeControllerIndexTest
    {
        [Fact]
        public async Task HomeIndexTests()
        {
            // Arrange
            var mockRepo = new Mock<IRestApiCaller>();
            mockRepo.Setup(repo => repo.VehiclesAsync())
                .ReturnsAsync(GetTestVehicles());

            HomeController controller = new HomeController(mockRepo.Object);

            // Act
            var result = await controller.Index() ;

            // Assert         
            var viewResult = Assert.IsType<ViewResult>(result); 
            var model = Assert.IsAssignableFrom<List<VehicleModel>>
                (viewResult.ViewData.Model); 

            Assert.Equal(2, model.Count);

        }


        private List<VehicleModel> GetTestVehicles()
        {
            var vehicles = new List<VehicleModel>();
            vehicles.Add(new VehicleModel()
            {
                Id = 1,
                VehicleId = "YS2R4X20005399401",
                RegNo = "ABC123",
                CustomerId = 1,
                CustomerName = "Kalles Grustransporter AB",
                CustomerAddress = "Cementvägen 8, 111 11 Södertälje",
                Status = "Connected"

            });
            vehicles.Add(new VehicleModel()
            {
                Id = 2,
                VehicleId = "VLUR4X20009093588",
                RegNo = "DEF456",
                CustomerId = 2,
                CustomerName = "Kalles Grustransporter AB",
                CustomerAddress = "Cementvägen 8, 111 11 Södertälje",
                Status = "Disonnected"
            });
            return vehicles;
        }
    }
}
