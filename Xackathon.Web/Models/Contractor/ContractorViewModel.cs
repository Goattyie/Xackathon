namespace Xackathon.Models
{
    public enum OrganizationType
    {
        Executive,
        Supervising
    }
    public class ContractorViewModel
    {
        public long Id { get; set; }
        public string MnemonicName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ResponsiblePerson { get; set; }
        public string Image { get; set; }
        public string HashTag { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string PreControllerEmail { get; set; }
        public string TelegramChatId { get; set; }
        public string PublicWebsite { get; set; }
        public string MoreInfo { get; set; }
        public OrganizationType Type { get; set; }
        public IEnumerable<ShceduleViewModel> Shcedules { get; set; }
        public IEnumerable<ProblemCategoryViewModel> ProblemCategories { get; set; }
        public bool IsActive { get; set; }
        public bool GenerateDailyReport { get; set; }
        public bool NeedInformByEmail { get; set; }
        public bool NeedInformBySms { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
