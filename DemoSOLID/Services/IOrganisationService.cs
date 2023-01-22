using DemoSOLID.Models;

namespace DemoSOLID.Services
{
    public interface IOrganisationService
    {
        public OrganisationList GetAllOrganisations();
        public List<Organisations> GetTechComapanies();
        public Organisations GetOrganisationById(int id);
    }
}
