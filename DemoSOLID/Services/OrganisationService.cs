using DemoSOLID.DataService;
using DemoSOLID.Models;
using DemoSOLID.ViewModels;

namespace DemoSOLID.Services
{
    public class OrganisationService : IOrganisationService
    {
        private readonly IOrganisationDataService _organisationDataService;
        private readonly IFundsDataService _fundsDataService;
        private readonly IAssetsDataService _assetDataService;
        private readonly IAssetsService _assetService;
        public OrganisationService( IOrganisationDataService organisationDataService, IFundsDataService fundsDataService, IAssetsDataService assetDataService, IAssetsService assetService)
        {
            _organisationDataService = organisationDataService;
            _fundsDataService = fundsDataService;
            _assetDataService = assetDataService;
            _assetService = assetService;

        }
        public OrganisationList GetAllOrganisations()
        {
            var res = _organisationDataService.GetAllOrganisations();

            return res;
        }

        public Organisations GetOrganisationById(int id)
        {
            var organisationList = _organisationDataService.GetAllOrganisations();
            var res = organisationList?.Organisations?.Where(organisation => organisation.ID == id).FirstOrDefault();
            return res;
        }

        public OgranisationDetailViewModel GetOrganisationDetails(int id)
        {
            var organisation = _organisationDataService?.GetAllOrganisations()?.Organisations?.Where(organisation => organisation.ID == id).FirstOrDefault();
            var funds = _fundsDataService.GetAllFunds()?.Funds?.Where(fund=>fund.OrganisationID==id).ToList();
            var allAssets = _assetDataService.GetAllAssetsAsList();
            var assets = allAssets.Join(
                funds,
                asset => asset.FundId,
                fund => fund.ID,
                (asset, fund) => new Assets
                {
                    AssetName = asset.AssetName,
                    FundId = asset.FundId,
                    ID = asset.ID
                }).ToList();

            OgranisationDetailViewModel res = new OgranisationDetailViewModel
            {
                Organisation = organisation,
                Funds = funds,
                Assets = assets
            };
            return res;

        }

        public List<Organisations> GetTechCompanies()
        {
            var organisationList = _organisationDataService.GetAllOrganisations();
            var res = organisationList?.Organisations?.Where(organisation => organisation.OrgType == 1).ToList();
            return res;
        }

        public List<Organisations> GetCompaniesByRevnue()
        {
            var organisationList = _organisationDataService.GetAllOrganisations();
            var res = organisationList?.Organisations?
                .Take(3)
                .OrderByDescending(Organisation => Organisation.Revenue)
                .ThenBy(organisation => organisation.OrgName)
                .ToList();
            return res;
        }
    }
}
