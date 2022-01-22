using Xackathon.Bll.Model;
using Xackathon.Dal.Models;

namespace Xackathon.Bll
{
    static class DomainHelper
    {
        public static IEnumerable<RoleDomainModel> ToRoleDomainArray(this IEnumerable<Role> model)
        {
            return model.Select(x => new RoleDomainModel()
            {
                Id = x.Id,
                Slug = x.MnemonicName,
                Title = x.Title,
                CreatedAt = x.CreatedAt.ToFormatString(),
                DeletedAt = x.DeletedAt.ToFormatString(),
                UpdatedAt = x.UpdatedAt.ToFormatString()
            });
        }

        public static RoleDomainModel ToRoleDomain(this Role model)
        {
            if (model == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            return new RoleDomainModel()
            {
                Id = model.Id,
                Slug = model.MnemonicName,
                Title = model.Title,
                CreatedAt = model.CreatedAt.ToFormatString(),
                DeletedAt = model.DeletedAt.ToFormatString(),
                UpdatedAt = model.UpdatedAt.ToFormatString()
            };
        }

        public static IEnumerable<RegionDomainModel> ToRegionDomainArray(this IEnumerable<Region> model)
        {
            return model.Select(x => new RegionDomainModel
            {
                Id = x.Id,
                Title = x.Title,
                IsActive = x.IsActive,
                Positions = x.Positions,
                CreatedAt = x.CreatedAt.ToFormatString(),
                DeletedAt = x.DeletedAt.ToFormatString(),
                UpdatedAt = x.UpdatedAt.ToFormatString()
            });
        }
        public static RegionDomainModel ToRegionDomain(this Region model)
        {
            if (model == null)
                throw new Exception(Resources.Errors.ObjectNotFound);

            return new RegionDomainModel
            {
                Id = model.Id,
                Title = model.Title,
                IsActive = model.IsActive,
                Positions = model.Positions,
                CreatedAt = model.CreatedAt.ToFormatString(),
                DeletedAt = model.DeletedAt.ToFormatString(),
                UpdatedAt = model.UpdatedAt.ToFormatString()
            };
        }
    }
}
