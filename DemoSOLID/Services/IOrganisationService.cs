using DemoSOLID.Models;
using DemoSOLID.ViewModels;

namespace DemoSOLID.Services
{
    public interface IOrganisationService
    {
        public OrganisationList GetAllOrganisations();
        public List<Organisations> GetTechCompanies();
        public Organisations GetOrganisationById(int id);
        public OgranisationDetailViewModel GetOrganisationDetails(int id);
    }
}
