using DemoSOLID.Models;

namespace DemoSOLID.Services
{
    public interface IAssetsService
    {
        public AssetList GetAllAssets();
        public Assets GetAssetById(int id);
        public IQueryable<Assets> GetAllAssetsbyOData();

    }
}
