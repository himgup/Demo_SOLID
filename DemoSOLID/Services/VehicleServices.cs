using DemoSOLID.Models;
using Newtonsoft.Json;

namespace DemoSOLID.Services
{
    public class VehicleServices : IVehicleServices
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public VehicleServices(IWebHostEnvironment hostingEnvironment)
    {
        _hostingEnvironment = hostingEnvironment;
    }
        public VehicleList GetAllVehicles()
        {
            var rootPath = _hostingEnvironment.ContentRootPath; 

            var fullPath = Path.Combine(rootPath, "data.json"); 

            var jsonData = System.IO.File.ReadAllText(fullPath);

            if (string.IsNullOrWhiteSpace(jsonData)) 
                
            return null; //if no data is present then return null or error if you wish

            var res = JsonConvert.DeserializeObject<VehicleList>(jsonData);

            return res;
        }

        public string GetFourWheelers()
        {
            return "All Vehicles";
        }

        public string GetFileterdVehicles()
        {
            return "All Vehicles";
        }

    }
}
