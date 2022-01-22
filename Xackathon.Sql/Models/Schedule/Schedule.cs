namespace Xackathon.Dal.Models
{
    public class Schedule
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan StartAt { get; set; }
        public TimeSpan EndAt { get; set; }
        public bool IsWorkDay { get; set; }
    }
}
