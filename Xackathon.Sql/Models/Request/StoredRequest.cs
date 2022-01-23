namespace Xackathon.Dal.Models
{
    public class StoredRequest
    {
        public long Id { get; set; }
        public long ProfileId { get; set; }
        public string Description { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public IEnumerable<ProblemCategory> ProblemCategories { get; set; }
        public IEnumerable<MediaContent> Attachments { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Profile Profile { get; set; }
    }
}
