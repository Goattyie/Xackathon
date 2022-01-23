using Xackathon.Bll.Model;

namespace Xackathon.Web.Models
{
    public class RegionViewModel
    {
        public int Total { get; set; }
        public IEnumerable<RegionDomainModel> Data { get; set; }
    }
}
