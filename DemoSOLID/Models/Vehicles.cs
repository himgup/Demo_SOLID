namespace DemoSOLID.Models
{
    public class VehicleList
    {
        public Vehicle[]? Vehicles { get; set; }
    }
    public class Vehicle
    {
        public int ID { get; set; }
        public string? ModelName { get; set; }
        public int VehicleType { get; set; }
        public int VehicleMode { get; set; }
        public string? EngineDisplacement { get; set; }
        public string? SeatingCapacity { get; set; }
    }

   
}
