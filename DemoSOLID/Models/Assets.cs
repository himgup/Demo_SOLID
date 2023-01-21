namespace DemoSOLID.Models
{
    public class AssetList
    {
        public Assets[]? Assets { get; set; }
    }
    public class Assets
    {
        public int ID { get; set; }
        public string? AssetName { get; set; }
        public int FundId { get; set; }

    }
}
