using DemoSOLID.DataService;
using DemoSOLID.Models;
using DemoSOLID.ViewModels;

namespace DemoSOLID.Services
{
    public class OrganisationService : IOrganisationService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IOrganisationDataService _organisationDataService;
        private readonly IFundsDataService _fundsDataService;
        private readonly IAssetsDataService _assetDataService;
        private readonly IAssetsService _assetService;
        public OrganisationService(IWebHostEnvironment hostingEnvironment, IOrganisationDataService organisationDataService, IFundsDataService fundsDataService, IAssetsDataService assetDataService, IAssetsService assetService)
        {
            _hostingEnvironment = hostingEnvironment;
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
            var allAssets = _assetDataService.GetAllAssets();
            var assets = new List<Assets>();
            foreach(var fund in funds)
            {
                var asset = allAssets?.Assets?.Where(asset => asset.FundId == fund.ID)?.FirstOrDefault();
                if(asset != null)
                    assets.Add(asset);
            }

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
    }
}
