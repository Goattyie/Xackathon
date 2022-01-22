namespace Xackathon.Web.Models
{
    public enum Type
    {
        Image,
        Video
    }
    public class MediaContentViewModel
    {
        public Type Type { get; set; }
        public string Url { get; set; }
    }
}
