using DemoSOLID.DataService;
using DemoSOLID.Models;

namespace DemoSOLID.Services
{
    public class FundsService : IFundsService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IFundsDataService _fundsDataService;

        public FundsService(IWebHostEnvironment hostingEnvironment, IFundsDataService fundsDataService)
        {
            _hostingEnvironment = hostingEnvironment;
            _fundsDataService = fundsDataService;
        }
        public FundList GetAllFunds()
        {
            var res = _fundsDataService.GetAllFunds();

            return res;
        }
    }
}
