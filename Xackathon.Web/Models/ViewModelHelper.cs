using Xackathon.Bll.Model;

namespace Xackathon.Web.Models
{
    public static class ViewModelHelper
    {
        public static ProblemCategoryViewModelList ToViewModelList(this IEnumerable<ProblemCategoryViewModel> model)
        {
            return new ProblemCategoryViewModelList
            {
                Total = model.Count(),
                Data = model
            };
        }

        public static RequestViewModel ToViewModel(this RequestDomainModel model)
        {
            return new RequestViewModel
            {
                Id = model.Id,
                Profile = Auto.Mapper.Map<ProfileViewModel>(model.Profile),
                Description = model.Description,
                CreatedAt = model.CreatedAt,
                Latitude = model.Latitude,
                Location = model.Location,
                Email = model.Email,
                Longitude = model.Longitude,
                Content = Auto.Mapper.Map<IEnumerable<MediaContentViewModel>>(model.MediaContent),
                ProblemCategories = Auto.Mapper.Map<IEnumerable<ProblemCategoryViewModel>>(model.ProblemCategories),
                Rating = model.Rating,
                Source = model.Source.ToString(),
                WatchCount = model.WatchCount,
            };
        }
        public static IEnumerable<RequestViewModel> ToViewModel(this IEnumerable<RequestDomainModel> list)
        {
            return list.Select(model => new RequestViewModel
            {
                Id = model.Id,
                Profile = Auto.Mapper.Map<ProfileViewModel>(model.Profile),
                Description = model.Description,
                CreatedAt = model.CreatedAt,
                Latitude = model.Latitude,
                Location = model.Location,
                Longitude = model.Longitude,
                Email = model.Email,
                Content = Auto.Mapper.Map<IEnumerable<MediaContentViewModel>>(model.MediaContent),
                ProblemCategories = Auto.Mapper.Map<IEnumerable<ProblemCategoryViewModel>>(model.ProblemCategories),
                Rating = model.Rating,
                Source = model.Source.ToString(),
                WatchCount = model.WatchCount,
            });
        }

        public static RequestViewModelList ToViewModelList(this IEnumerable<RequestViewModel> model)
        {
            return new RequestViewModelList
            {
                Total = model.Count(),
                Data = model
            };
        }
    }
}
