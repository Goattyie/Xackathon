using Xackathon.Bll.Model;

namespace Xackathon.Web.Models
{

    public class StoryViewModel
    {
        public int Total { get; set; }
        public IEnumerable<StoryDomainModel> Data { get; set; }
    }
}
