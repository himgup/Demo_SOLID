using DemoSOLID.Models;
using DemoSOLID.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoSOLID.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        private readonly IAssetsService _assetService;
        public AssetController(IAssetsService assetService)
        {
            _assetService = assetService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AssetList))]
        public IActionResult Get()
        {
            return Ok(_assetService.GetAllAssets());
        }
    }
}
