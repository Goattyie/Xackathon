namespace Xackathon.Models
{
    public class RegionViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int Positions { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
