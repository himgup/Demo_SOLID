using DemoSOLID.Models;

namespace DemoSOLID.DataService
{
    public interface IOrganisationDataService
    {
        public OrganisationList GetAllOrganisations();
        public IQueryable<Organisations> GetAllOrganisationsbyOdata();

    }
}
