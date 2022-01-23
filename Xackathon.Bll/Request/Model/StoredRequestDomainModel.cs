using Xackathon.Dal.Models;

namespace Xackathon.Bll.Model
{
    public class StoredRequestDomainModel
    {
        public long Id { get; set; }
        public long ProfileId { get; set; }
        public string Description { get; set; }
        public IEnumerable<ProblemCategoryDomainModel> ProblemCategories { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public IEnumerable<MediaContentDomainModel> Attachments { get; set; }
        public string DeletedAt { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public static explicit operator StoredRequest(StoredRequestDomainModel obj)
        {
            return new StoredRequest
            {
                Id = obj.Id,
                ProfileId = obj.ProfileId,
                Description = obj.Description,
                Latitude = obj.Latitude,
                Longitude = obj.Longitude,
                CreatedAt = obj.CreatedAt.ToNullableDateTime(),
                Attachments = obj.Attachments.Select(x => (MediaContent)x),
                DeletedAt = obj.DeletedAt.ToNullableDateTime(),
                ProblemCategories = obj.ProblemCategories.Select(x=>(ProblemCategory)x),
                UpdatedAt = obj.UpdatedAt.ToNullableDateTime(),
            };
        }
    }
}
