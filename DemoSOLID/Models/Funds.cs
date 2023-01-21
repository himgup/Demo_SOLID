namespace DemoSOLID.Models
{
    public class FundList
    {
        public Funds[]? Funds { get; set; }
    }
    public class Funds
    {
        public int ID { get; set; }
        public string? FundName { get; set; }
        public int OrganisationID { get; set; }

    }
}
