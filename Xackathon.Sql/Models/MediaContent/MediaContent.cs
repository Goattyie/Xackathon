using Xackathon.Abstractions;

namespace Xackathon.Dal.Models
{
    public class MediaContent
    {
        public long Id { get; set; }
        public ContentType Type { get; set; }
        public string Url { get; set; }
    }
}
