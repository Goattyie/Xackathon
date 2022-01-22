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
                CreatedAt = x.CreatedAt.ToString(),
                DeletedAt = x.DeletedAt.ToString(),
                UpdatedAt = x.UpdatedAt.ToString()
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
                CreatedAt = model.CreatedAt.ToString(),
                DeletedAt = model.DeletedAt.ToString(),
                UpdatedAt = model.UpdatedAt.ToString()
            };
        }
    }
}
