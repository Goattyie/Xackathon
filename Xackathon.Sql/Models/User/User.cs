namespace Xackathon.Dal.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ApproveSmsCode { get; set; }
        public string ApproveEmailCode { get; set; }
        public DateTime? SmsApprovedAt { get; set; }
        public DateTime? EmailApprovedAt { get; set; }
        public DateTime? BlockedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
