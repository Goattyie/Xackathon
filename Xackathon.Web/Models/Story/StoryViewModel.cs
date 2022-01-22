namespace Xackathon.Web.Models
{
    public enum ContentType
    {
        Image,
        Video
    }
    public enum StoryType
    {
        Information,
        Danger
    }
    public class StoryViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string GroupName { get; set; }
        public int Position { get; set; }
        public ContentType ContentType { get; set; }
        public string ContentUrl { get; set; }
        public DateTime LiveTo { get; set; }
        public float Duration { get; set; }
        public StoryType StoryType { get; set; }
        public long ModeratorId { get; set; }
        public bool IsActive { get; set; }
        public int WatchCount { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
