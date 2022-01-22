namespace Xackathon.Web.Models
{
    public class ProblemCategoryViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string MnemonicName { get; set; }
        public string HashTag { get; set; }
        public string Icon { get; set; }
        public int Rating { get; set; }
        public bool IsActive { get; set; }
        public bool IsVisible { get; set; }
        public DateTime DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
