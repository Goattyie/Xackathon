using Xackathon.Abstractions;
using Xackathon.Dal.Models;

namespace Xackathon.Bll.Model
{
    public class MediaContentDomainModel
    {
        public ContentType Type { get; set; }
        public string Url { get; set; }
        public static explicit operator MediaContent(MediaContentDomainModel obj)
        {
            return new MediaContent
            {
                Type = obj.Type,
                Url = obj.Url,
            };
        }
    }
}
