using DemoSOLID.Models;
using DemoSOLID.Utility;
using Newtonsoft.Json;

namespace DemoSOLID.DataService
{
    public class OrganisationDataService : IOrganisationDataService
    {
        public OrganisationList GetAllOrganisations()
        {
            var jsonData = ReadJson.ReadJsonFile();

            var result = JsonConvert.DeserializeObject<OrganisationList>(jsonData);

            return result;
        }

        public IQueryable<Organisations> GetAllOrganisationsbyOdata()
        {
            var jsonData = ReadJson.ReadJsonFile();

            var result = JsonConvert.DeserializeObject<OrganisationList>(jsonData).Organisations.AsQueryable();

            return result;
        }
    }
}
