using DemoSOLID.Models;

namespace DemoSOLID.Services
{
    public interface IFundsService
    {
        public FundList GetAllFunds();
        public Funds GetFundById(int id);
    }
}
