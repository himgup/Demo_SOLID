using System;
using DemoSOLID.Models;
using DemoSOLID.Utility;
using Newtonsoft.Json;

namespace DemoSOLID.DataService
{
    public class AssetsDataService : IAssetsDataService
    {
        public AssetList GetAllAssets()
        {
            var jsonData = ReadJson.ReadJsonFile();

            var result = JsonConvert.DeserializeObject<AssetList>(jsonData);

            return result;
        }

        public IQueryable<Assets> GetAllAssetsbyOData()
        {
            var jsonData = ReadJson.ReadJsonFile();

            var result = JsonConvert.DeserializeObject<AssetList>(jsonData).Assets.AsQueryable();

            return result;
        }
    }
}
