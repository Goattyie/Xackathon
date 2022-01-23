using Xackathon.Bll;
using Xackathon.Bll.Model;

namespace Xackathon.Web.Models
{
    public class ProblemCategoryForm
    {
        public string Title { get; set; }
        public string MnemonicName { get; set; }
        public string HashTag { get; set; }
        public string Icon { get; set; }
        public int Rating { get; set; }
        public bool IsActive { get; set; }
        public bool IsVisible { get; set; }
        public static explicit operator ProblemCategoryDomainModel(ProblemCategoryForm obj)
        {
            return new ProblemCategoryDomainModel
            {
                Title = obj.Title,
                MnemonicName = obj.MnemonicName,
                HashTag = obj.HashTag,
                Icon = obj.Icon,
                Rating = obj.Rating,
                IsActive = obj.IsActive,
                CreatedAt = DateTime.Now.ToFormatString(),
                UpdatedAt = DateTime.Now.ToFormatString(),
                DeletedAt = DateTime.Now.ToFormatString()
            };
        }
    }
}
