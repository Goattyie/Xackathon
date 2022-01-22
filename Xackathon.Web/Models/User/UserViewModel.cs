namespace Xackathon.Web.Models
{
    public class UserViewModel
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ProfileViewModel Profile { get; set; }
        public IEnumerable<RoleViewModel> Roles { get; set; }
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
