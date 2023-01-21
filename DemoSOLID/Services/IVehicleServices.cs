using DemoSOLID.Models;

namespace DemoSOLID.Services
{
    public interface IVehicleServices
    {
        public VehicleList GetAllVehicles();
        public List<Vehicle> GetFourWheelers();
        public Vehicle GetVehicleById(int id);
    }
}
