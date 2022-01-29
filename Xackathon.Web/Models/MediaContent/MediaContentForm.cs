using Xackathon.Abstractions;

namespace Xackathon.Web.Models
{
    public class MediaContentForm
    {
        /// <summary>
        /// Тип медиа:
        /// Image (0), Video (1)
        /// </summary>
        /// <example>0</example>
        public ContentType Type { get; set; }
        /// <summary>
        /// Ссылка на ресурс
        /// </summary>
        /// <example>https://vjoy.cc/wp-content/uploads/2020/11/c005f0f1005aea6ad5aba7a824c63b66.png</example>
        public string Url { get; set; }
    }
}
