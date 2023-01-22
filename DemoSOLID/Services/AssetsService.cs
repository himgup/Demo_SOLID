using DemoSOLID.DataService;
using DemoSOLID.Models;

namespace DemoSOLID.Services
{
    public class AssetsService : IAssetsService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IAssetsDataService _assetDataService;

        public AssetsService(IWebHostEnvironment hostingEnvironment, IAssetsDataService assetDataService)
        {
            _hostingEnvironment = hostingEnvironment;
            _assetDataService = assetDataService;
        }
        public AssetList GetAllAssets()
        {
            var res = _assetDataService.GetAllAssets();

            return res;
        }

        public Assets GetAssetById(int id)
        {

            var assetList = _assetDataService.GetAllAssets();
            var res = assetList?.Assets?.Where(asset => asset.ID == id).FirstOrDefault();
            return res;
        }
    }
}
