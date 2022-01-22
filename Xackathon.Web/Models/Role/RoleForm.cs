using Xackathon.Bll.Model;

namespace Xackathon.Web.Models
{
    public class RoleForm
    {
        public string Title { get; set; }
        public string Slug { get; set; }

        public static explicit operator RoleDomainModel(RoleForm obj)
        {
            return new RoleDomainModel
            {
                Title = obj.Title,
                Slug = obj.Slug,
                CreatedAt = DateTime.Now.ToString(),
                UpdatedAt = DateTime.Now.ToString(),
                DeletedAt = DateTime.Now.ToString(),
            };
        }
    }
}
