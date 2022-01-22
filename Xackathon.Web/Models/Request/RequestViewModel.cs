namespace Xackathon.Web.Models
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
    public class RequestViewModel
    {
        public long Id { get; set; }
        public long? ParentRequestId { get; set; }
        public string Description { get; set; }
        public Source Source { get; set; }
        public IEnumerable<ProblemCategoryViewModel> ProblemCategories { get; set; }
        public string Location { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int BaseRating { get; set; }
        public int Rating { get; set; }
        public int WatchCount { get; set; }
        public Status Status { get; set; }
        public IEnumerable<MediaContentViewModel> MediaContent { get; set; }
        public StoredProfileDataViewModel StoredProfileData { get; set; }
        public DateTime RequestConsiderationAt { get; set; }
        public DateTime BeginRequestConsiderationAt { get; set; }
        public DateTime CompleteRequestExecutionAt { get; set; }
        public bool IsModerated { get; set; }
        public long ModeratorId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
