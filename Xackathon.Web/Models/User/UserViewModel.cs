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
        public string SmsApprovedAt { get; set; }
        public string EmailApprovedAt { get; set; }
        public string BlockedAt { get; set; }
        public string DeletedAt { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
