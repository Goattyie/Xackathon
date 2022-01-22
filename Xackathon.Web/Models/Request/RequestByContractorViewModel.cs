namespace Xackathon.Web.Models
{
    public class RequestByContractorViewModel
    {
        public long Id { get; set; }
        public long ConstractorId { get; set; }
        public long RequestId { get; set; }
        public OrganizationType Type { get; set; }
        public string Description { get; set; }
        public IEnumerable<MediaContentViewModel> Attachments { get; set; }
        public DateTime? WorkedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
