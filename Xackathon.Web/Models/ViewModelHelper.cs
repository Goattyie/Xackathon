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
        public static RegionViewModel ToRegionViewModel(this IEnumerable<RegionDomainModel> obj)
        {
            return new RegionViewModel
            {
                Total = obj.Count(),
                Data = obj
            };
        }

        public static StoryViewModel ToStoryViewModel(this IEnumerable<StoryDomainModel> obj)
        {
            var viewModel = new StoryViewModel();
            viewModel.Total = obj.Count();
            viewModel.Data = obj;
            
            return viewModel;
        }
    }
}
