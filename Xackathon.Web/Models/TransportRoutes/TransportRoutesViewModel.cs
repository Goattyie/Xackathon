namespace Xackathon.Web.Models
{
    public class TransportRoutesViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string RouteNumber { get; set; }
        public string CarNumber { get; set; }
        public UserViewModel DriversOnRoute { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
