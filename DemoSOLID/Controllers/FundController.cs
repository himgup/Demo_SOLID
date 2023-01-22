using DemoSOLID.Models;
using DemoSOLID.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoSOLID.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundController : ControllerBase
    {
        private readonly IFundsService _fundService;
        public FundController(IFundsService fundService)
        {
            _fundService = fundService;
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FundList))]
        public IActionResult Get()
        {
            return Ok(_fundService.GetAllFunds());
        }
        [HttpGet("{id}")]
        public IActionResult GetFundById(int id)
        {
            return Ok(_fundService.GetFundById(id));
        }
    }
}
