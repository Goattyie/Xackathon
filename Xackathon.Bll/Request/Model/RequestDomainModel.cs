using Xackathon.Dal.Models;

namespace Xackathon.Bll.Model
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
    public class RequestDomainModel
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
        public string RequestConsiderationAt { get; set; }
        public string BeginRequestConsiderationAt { get; set; }
        public string CompleteRequestExecutionAt { get; set; }
        public bool IsModerated { get; set; }
        public long ModeratorId { get; set; }
        public string ProblemDescription { get; set; }
        public string DeletedAt { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public int ViewCount { get; set; }

        public static explicit operator Request(RequestDomainModel obj)
        {
            return new Request
            {
                Id = obj.Id,
                UserId = obj.UserId,
                ParentRequestId = obj.ParentRequestId,
                Location = obj.Location,
                Latitude = obj.Latitude,
                Longitude = obj.Longitude,
                MediaContentId = obj.MediaContentId,
                Content = obj.Content,
                Status = (Dal.Models.Status)obj.Status,
                Source = (Dal.Models.Source)obj.Source,
                BaseRating = obj.BaseRating,
                WatchCount = obj.WatchCount,
                RequestConsiderationAt = obj.RequestConsiderationAt.ToDateTime(),
                BeginRequestConsiderationAt = obj.BeginRequestConsiderationAt.ToDateTime(),
                CompleteRequestExecutionAt = obj.CompleteRequestExecutionAt.ToDateTime(),
                IsModerated = obj.IsModerated,
                ModeratorId = obj.ModeratorId,
                ProblemDescription = obj.ProblemDescription,
                DeletedAt = obj.DeletedAt.ToNullableDateTime(),
                CreatedAt = obj.CreatedAt.ToNullableDateTime(),
                UpdatedAt = obj.UpdatedAt.ToNullableDateTime(),
                ViewCount = obj.ViewCount
            };
        }
    }
}
