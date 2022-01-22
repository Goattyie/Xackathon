namespace Xackathon.Dal.Models
{
    public class StoppingPoint
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ManagerCompany { get; set; }
        public string City { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
