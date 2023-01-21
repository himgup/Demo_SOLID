using DemoSOLID.DataService;
using DemoSOLID.Models;

namespace DemoSOLID.Services
{
    public class OrganisationService : IOrganisationService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IOrganisationDataService _organisationDataService;
        public OrganisationService(IWebHostEnvironment hostingEnvironment, IOrganisationDataService organisationDataService)
        {
            _hostingEnvironment = hostingEnvironment;
            _organisationDataService = organisationDataService;
        }
        public OrganisationList GetAllOrganisations()
        {
            var res = _organisationDataService.GetAllOrganisations();

            return res;
        }

        public Organisations GetOrganisationById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Organisations> GetTechComapanies()
        {
            throw new NotImplementedException();
        }
    }
}
