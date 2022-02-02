using Xackathon.Abstractions;

namespace Xackathon.Bll.Model
{
    public class RequestDomainModel
    {
        public long Id { get; set; }
        public string Location { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public ProfileDomainModel Profile { get; set; }
        public IEnumerable<MediaContentDomainModel> MediaContent { get; set; }
        public IEnumerable<ProblemCategoryDomainModel> ProblemCategories { get; set; }
        public string Description { get; set; }
        public Source Source { get; set; }
        public int Rating { get; set; }
        public string Email { get; set; }
        public int WatchCount { get; set; }
        public string CreatedAt { get; set; }
    }
}
