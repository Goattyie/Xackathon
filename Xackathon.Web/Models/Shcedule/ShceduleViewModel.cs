namespace Xackathon.Web.Models
{
    public class ShceduleViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public TimeSpan StartAt { get; set; }
        public TimeSpan EndAt { get; set; }
        public bool IsDayOf { get; set; }
        public string Description { get; set; }
    }
}
