using DemoSOLID.DataService;
using DemoSOLID.Models;
using Newtonsoft.Json;
using System.Linq;

namespace DemoSOLID.Services
{
    public class VehicleServices : IVehicleServices
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IVehicleDataService _vehicleDataService;

        public VehicleServices(IWebHostEnvironment hostingEnvironment, IVehicleDataService vehicleDataService)
        {
            _hostingEnvironment = hostingEnvironment;
            _vehicleDataService = vehicleDataService;
        }
        public VehicleList GetAllVehicles()
        {
            var res = _vehicleDataService.GetAllVehicles();

            return res;
        }

        public List<Vehicle> GetFourWheelers()
        {
            var res = _vehicleDataService.GetAllVehicles();
            var finalRes = res?.Vehicles?.Where(Vehicle => Vehicle.VehicleType == 1).ToList();
            return finalRes;
        }

        public string GetFileterdVehicles()
        {
            return "All Vehicles";
        }

        public Vehicle GetVehicleById(int id)
        {
            var res = _vehicleDataService.GetAllVehicles();
            var finalRes = res?.Vehicles?.Where(Vehicle => Vehicle.ID == id).FirstOrDefault();
            return finalRes;

        }
    }
}
