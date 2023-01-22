using DemoSOLID.Models;
using DemoSOLID.Utility;
using Newtonsoft.Json;

namespace DemoSOLID.DataService
{
    public class FundsDataService : IFundsDataService
    {
       
        public FundList GetAllFunds()
        {
            var jsonData = ReadJson.ReadJsonFile();

            var result = JsonConvert.DeserializeObject<FundList>(jsonData);

            return result;
        }
    }
}
