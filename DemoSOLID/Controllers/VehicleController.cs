using DemoSOLID.Models;
using DemoSOLID.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoSOLID.Controllers

{

    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {

        private readonly IVehicleServices _vehicleServices;

        public VehicleController(IVehicleServices vehicleServices)
        {
            _vehicleServices = vehicleServices;
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VehicleList))]

        public IActionResult Get()
        {
            return Ok(_vehicleServices.GetAllVehicles());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_vehicleServices.GetVehicleById(id));
        }
        
        //Get 
        [HttpGet]
        [Route("FourWheelers")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VehicleList))]
        public IActionResult GetfourWheelers()
        {
            return Ok(_vehicleServices.GetFourWheelers());
        }

    }
}
