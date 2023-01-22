namespace DemoSOLID.Models
{
    public class OrganisationList
    {
        public Organisations[]? Organisations { get; set; }
    }
    public class Organisations
    {
        public int ID { get; set; }
        public string? OrgName { get; set; }
        public double Revenue { get; set; }
        public int OrgType { get; set; }
        public string? FoundingYear { get; set; }
        public string? Country { get; set; }
    }
}
