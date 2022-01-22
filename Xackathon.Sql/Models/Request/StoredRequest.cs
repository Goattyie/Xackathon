namespace Xackathon.Dal.Models
{
    public class StoredRequest
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Description { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public IEnumerable<MediaContent> Accachments { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
