using DemoSOLID.Models;

namespace DemoSOLID.ViewModels
{
    public class OgranisationDetailViewModel
    {
        public Organisations? Organisation { get; set; }
        public List<Funds>? Funds { get; set; }
        public List<Assets>? Assets { get; set; }
    }
}
