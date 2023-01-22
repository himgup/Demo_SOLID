using DemoSOLID.Models;
using Newtonsoft.Json;

namespace DemoSOLID.DataService
{
    public class AssetsDataService : IAssetsDataService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public AssetsDataService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public AssetList GetAllAssets()
        {
            var rootPath = _hostingEnvironment.ContentRootPath;

            var fullPath = Path.Combine(rootPath, "data.json");


            var jsonData = System.IO.File.ReadAllText(fullPath);

            if (string.IsNullOrWhiteSpace(jsonData))

                return null; //if no data is present then return null or error if you wish

            var res = JsonConvert.DeserializeObject<AssetList>(jsonData);

            return res;
        }
    }
}
