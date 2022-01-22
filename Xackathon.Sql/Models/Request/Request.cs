namespace Xackathon.Dal.Models
{
    public enum Source
    {
        Landing,
        Vk,
        Operator,
        Excel,
        Telegram,
        Android,
        Ios,
        Other
    }

    public enum Status
    {
        InProcessing,
        InConsideration,
        InExecution,
        InExecutionCheck,
        Completed,
        Archived,
    }
    public class Request
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long? ParentRequestId { get; set; }
        public string Location { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public long MediaContentId { get; set; }
        public string Content { get; set; }
        public Status Status { get; set; }
        public Source Source { get; set; }
        public int BaseRating { get; set; }
        public int Rating { get; set; }
        public int WatchCount { get; set; }
        public DateTime RequestConsiderationAt { get; set; }
        public DateTime BeginRequestConsiderationAt { get; set; }
        public DateTime CompleteRequestExecutionAt { get; set; }
        public bool IsModerated { get; set; }
        public long ModeratorId { get; set; }
        public string ProblemDescription { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int ViewCount { get; set; }

    }
}
