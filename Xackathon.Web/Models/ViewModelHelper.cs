using Xackathon.Bll.Model;

namespace Xackathon.Web.Models
{
    public static class ViewModelHelper
    {
        public static RoleViewModel ToRoleViewModel(this IEnumerable<RoleDomainModel> obj)
        {
            return new RoleViewModel
            {
                Total = obj.Count(),
                Data = obj
            };
        }
    }
}
