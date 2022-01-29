using Xackathon.Abstractions;
using Xackathon.Dal.Models;

namespace Xackathon.Bll.Model
{
    public class RequestFormDomainModel
    {
        public string FIO { get; set; }
        public string Phone { get; set; }
        public Source Source { get; set; }
        public IEnumerable<MediaContentDomainModel> Content { get; set; }
        public string Location { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Description { get; set; }
        public IEnumerable<int> ProblemCategories { get; set; }
        public int WatchCount { get; set; }
        public string CreatedAt { get; set; }

        public static explicit operator Request(RequestFormDomainModel form)
        {
            var request = new Request();

            request.Source = form.Source;
            request.Rating = 0;
            request.Location = form.Location;
            request.Latitude = form.Latitude;
            request.Longitude = form.Longitude;
            request.Description = form.Description;
            request.CreatedAt = form.CreatedAt.ToNullableDateTime();
            request.WatchCount = form.WatchCount;
            request.MediaContent = Auto.Mapper.Map<IEnumerable<MediaContent>>(form.Content);

            return request;
        }

        public static explicit operator Profile(RequestFormDomainModel form)
        {
            var profile = new Profile();
            profile.Name = form.FIO;
            profile.Phone = form.Phone;

            return profile;
        }
    }
}
