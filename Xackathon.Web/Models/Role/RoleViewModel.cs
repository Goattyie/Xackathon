using Xackathon.Bll.Model;

namespace Xackathon.Web.Models
{
    public enum RoleTitle
    {
        Guest,
        User,
        Administrator,
        Constractor,
        ConstractorExecutive,
        ConstractorSupervising,
        Technical
    }
    public class RoleViewModel
    {
        public int Total { get; set; }
        public IEnumerable<RoleDomainModel> Data { get; set; }
    }
}
