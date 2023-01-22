using DemoSOLID.DataService;
using DemoSOLID.Models;

namespace DemoSOLID.Services
{
    public class FundsService : IFundsService
    {
        private readonly IFundsDataService _fundsDataService;

        public FundsService( IFundsDataService fundsDataService)
        {
            _fundsDataService = fundsDataService;
        }
        public FundList GetAllFunds()
        {
            var res = _fundsDataService.GetAllFunds();

            return res;
        }

        public Funds GetFundById(int id)
        {
            var fundList = _fundsDataService.GetAllFunds();
            var res = fundList?.Funds?.Where(fund => fund.ID == id).FirstOrDefault();
            return res;
        }
    }
}
