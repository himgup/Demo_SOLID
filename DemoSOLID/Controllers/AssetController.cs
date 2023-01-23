using DemoSOLID.Models;
using DemoSOLID.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

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

        [HttpGet("{id}")]
        public IActionResult GetAssetById(int id)
        {
            return Ok(_assetService.GetAssetById(id));
        }

        [HttpGet]
        [Route("Odata")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Assets))]
        [EnableQuery]
        public IActionResult GetAll()
        {
            return Ok(_assetService.GetAllAssetsbyOData());
        }

        [HttpGet]
        [Route("groupedAssets")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AssetList))]
        public IActionResult GetAssetsByFunds()
        {
            return Ok(_assetService.GetAssetsByFunds());
        }
    }
}
