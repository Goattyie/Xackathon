using Xackathon.Dal.Models;

namespace Xackathon.Bll.Model
{
    public class StoryDomainModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string GroupName { get; set; }
        public int Position { get; set; }
        public string Author { get; set; }
        public ContentType ContentType { get; set; }
        public string ContentUrl { get; set; }
        public string LiveTo { get; set; }
        public float Duration { get; set; }
        public StoryType StoryType { get; set; }
        public long ModeratorId { get; set; }
        public bool IsActive { get; set; }
        public int WatchCount { get; set; }
        public string DeletedAt { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public static explicit operator Story(StoryDomainModel model)
        {
            if (model == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            return new Story
            {
                Id = model.Id,
                Title = model.Title,
                TextContent = model.Content,
                GroupName = model.GroupName,
                Position = model.Position,
                ContentType = model.ContentType,
                ContentUrl = model.ContentUrl,
                LiveTo = model.LiveTo.ToDateTime(),
                Duration = model.Duration,
                AuthorName = model.Author,
                WatchCount = model.WatchCount,
                IsActive = model.IsActive,
                StoryType = model.StoryType,
                ModeratorId = model.ModeratorId,
                CreatedAt = model.CreatedAt.ToNullableDateTime(),
                DeletedAt = model.DeletedAt.ToNullableDateTime(),
                UpdatedAt = model.UpdatedAt.ToNullableDateTime()
            };
        }
    }
}
