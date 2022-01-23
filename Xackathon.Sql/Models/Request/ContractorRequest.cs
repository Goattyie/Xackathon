using Xackathon.Abstractions;

namespace Xackathon.Dal.Models
{
    public class ContractorRequest
    {
        public long Id { get; set; }
        public long ConstractorId { get; set; }
        public long RequestId { get; set; }
        public OrganizationType Type { get; set; }
        public string ControllerName { get; set; }
        public string Description { get; set; }
        public string ControllerContactPhone { get; set; }
        public string Email { get; set; }
        public IEnumerable<MediaContent> Attachments { get; set; }
        public DateTime? WorkedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Contractor Contractor { get; set; }
        public Request Request { get; set; }
    }
}
