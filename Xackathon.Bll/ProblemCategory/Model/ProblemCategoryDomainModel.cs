using Xackathon.Dal.Models;

namespace Xackathon.Bll.Model
{
    public class ProblemCategoryDomainModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string MnemonicName { get; set; }
        public string HashTag { get; set; }
        public string Icon { get; set; }
        public int Rating { get; set; }
        public string CreatedAt { get; set; }

        public static explicit operator ProblemCategory(ProblemCategoryDomainModel obj)
        {
            return new ProblemCategory
            {
                Id = obj.Id,
                Title = obj.Title,
                MnemonicName = obj.MnemonicName,
                HashTag = obj.HashTag,
                Icon = obj.Icon,
                Rating = obj.Rating,
                CreatedAt = obj.CreatedAt.ToDateTime(),

            };
        }
    }
}
