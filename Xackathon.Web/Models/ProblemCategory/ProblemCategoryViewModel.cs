using Xackathon.Bll.Model;

namespace Xackathon.Web.Models
{
    public class ProblemCategoryViewModelList
    {
        public int Total { get; set; }
        public IEnumerable<ProblemCategoryViewModel> Data { get; set; }
    }

    public class ProblemCategoryViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string MnemonicName { get; set; }
        public string HashTag { get; set; }
        public string Icon { get; set; }
        public int Rating { get; set; }
        public string CreatedAt { get; set; }

        public static explicit operator ProblemCategoryDomainModel(ProblemCategoryViewModel obj)
        {
            return new ProblemCategoryDomainModel
            {
                Id = obj.Id,
                Title = obj.Title,
                MnemonicName = obj.MnemonicName,
                HashTag = obj.HashTag,
                Icon = obj.Icon,
                Rating = obj.Rating,
                CreatedAt = obj.CreatedAt,
            };
        }
    }
}
