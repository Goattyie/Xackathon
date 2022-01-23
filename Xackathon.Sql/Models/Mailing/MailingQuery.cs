using Xackathon.Abstractions;

namespace Xackathon.Dal.Models
{
    public class MailingQuery
    {
        public long Id { get; set; }
        public string AddressTo { get; set; }
        public MailingType Type { get; set; }
        public SendStatus Status { get; set; }
        public string TemplateName { get; set; }
        public MessageObject MessageObject { get; set; }
        public long RequestId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Request Request { get; set; }
    }
}
