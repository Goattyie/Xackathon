using Xackathon.Bll.Model;
using Xackathon.Dal.Models;

namespace Xackathon.Bll
{
    static class DomainHelper
    {
        public static IEnumerable<ProblemCategoryDomainModel> ToProblemCategoryDomainArray(this IEnumerable<ProblemCategory> model)
        {
            return model.Select(x => new ProblemCategoryDomainModel
            {
                Id = x.Id,
                Title = x.Title,
                Icon = x.Icon,
                HashTag = x.HashTag,
                MnemonicName = x.MnemonicName,
                Rating = x.Rating,
                CreatedAt = x.CreatedAt.ToFormatString(),
            });
        }
        public static ProblemCategoryDomainModel ToProblemCategoryDomain(this ProblemCategory model)
        {
            if (model == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            return new ProblemCategoryDomainModel
            {
                Id = model.Id,
                Title = model.Title,
                Icon = model.Icon,
                HashTag = model.HashTag,
                MnemonicName = model.MnemonicName,
                Rating = model.Rating,
                CreatedAt = model.CreatedAt.ToFormatString(),
            };
        }
        public static IEnumerable<RequestDomainModel> ToRequestDomainArray(this IEnumerable<Request> list) 
        {
            return list.Select(model => new RequestDomainModel
            {
                Id = model.Id,
                Profile = Auto.Mapper.Map<ProfileDomainModel>(model.Profile),
                Location = model.Location,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                Source = model.Source,
                Email = model.Email,
                Description = model.Description,
                WatchCount = model.WatchCount,
                Rating = model.Rating,
                MediaContent = Auto.Mapper.Map<IEnumerable<MediaContentDomainModel>>(model.MediaContent),
                ProblemCategories = model.ProblemCategories.ToProblemCategoryDomainArray(),
                CreatedAt = model.CreatedAt.ToFormatString(),
            });
        }
        public static RequestDomainModel ToRequestDomain(this Request model)
        {
            if (model == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            return new RequestDomainModel
            {
                Id = model.Id,
                Profile = Auto.Mapper.Map<ProfileDomainModel>(model.Profile),
                Location = model.Location,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                Description = model.Description,
                WatchCount = model.WatchCount,
                Rating = model.Rating,
                Email = model.Email,
                ProblemCategories = model.ProblemCategories.ToProblemCategoryDomainArray(),
                MediaContent = Auto.Mapper.Map<IEnumerable<MediaContentDomainModel>>(model.MediaContent),
            };
        }
        public static IEnumerable<MediaContentDomainModel> ToMediaDomainArray(this IEnumerable<MediaContent> list)
        {
            return list.Select(model => new MediaContentDomainModel
            {
                Type = model.Type,
                Url = model.Url
            });
        }
        public static MediaContentDomainModel ToMediaDomain(this MediaContent model)
        {
            return new MediaContentDomainModel
            {
                Type = model.Type,
                Url = model.Url
            };
        }
    }
}
