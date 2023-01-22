using DemoSOLID.Models;

namespace DemoSOLID.DataService
{
    public interface IAssetsDataService
    {
        public AssetList GetAllAssets();
        public IQueryable<Assets> GetAllAssetsbyOData();
        public List<Assets> GetAllAssetsAsList();

    }
}
