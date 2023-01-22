using DemoSOLID.Models;
using Newtonsoft.Json;

namespace DemoSOLID.DataService
{
    public class OrganisationDataService : IOrganisationDataService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public OrganisationDataService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public OrganisationList GetAllOrganisations()
        {

            var rootPath = _hostingEnvironment.ContentRootPath;

            var fullPath = Path.Combine(rootPath, "data.json");


            var jsonData = System.IO.File.ReadAllText(fullPath);

            if (string.IsNullOrWhiteSpace(jsonData))

                return null; //if no data is present then return null or error if you wish

            var res = JsonConvert.DeserializeObject<OrganisationList>(jsonData);

            return res;
        }
    }
}
