using Xackathon.Bll;
using Xackathon.Bll.Model;
using Xackathon.Dal.Models;

namespace Xackathon.Web.Models
{
    public class StoryForm
    {
        public string Title { get; set; }
        public string GroupName { get; set; }
        public string Content { get; set; }
        public int Position { get; set; }
        public string Author { get; set; }
        public ContentType ContentType { get; set; }
        public string ContentUrl { get; set; }
        /// <example>2022-10-01 16:32:00</example>
        public string LiveTo { get; set; }
        public float Duration { get; set; }
        public StoryType StoryType { get; set; }
        public long ModeratorId { get; set; }
        public bool IsActive { get; set; }
    
        public static explicit operator StoryDomainModel(StoryForm obj)
        {
            return new StoryDomainModel
            {
                Title = obj.Title,
                GroupName = obj.GroupName,
                Content = obj.Content,
                ContentType = obj.ContentType,
                ContentUrl = obj.ContentUrl,
                LiveTo = obj.LiveTo,
                WatchCount = 0,
                IsActive = obj.IsActive,
                Position = obj.Position,
                Author = obj.Author,
                ModeratorId = obj.ModeratorId,
                StoryType = obj.StoryType,
                Duration = obj.Duration,
                CreatedAt = DateTime.Now.ToFormatString(),
                DeletedAt = DateTime.Now.ToFormatString(),
                UpdatedAt = DateTime.Now.ToFormatString()
            };
        }
    }
}
