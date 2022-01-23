using Xackathon.Dal.Models;

namespace Xackathon.Bll.Model
{
    public class UserDomainModel
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ProfileDomainModel Profile { get; set; }
        public IEnumerable<RoleDomainModel> Roles { get; set; }
        public string ApproveSmsCode { get; set; }
        public string ApproveEmailCode { get; set; }
        public string SmsApprovedAt { get; set; }
        public string EmailApprovedAt { get; set; }
        public string BlockedAt { get; set; }
        public string DeletedAt { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public static explicit operator User(UserDomainModel obj)
        {
            return new User
            {
                Id = obj.Id,
                Profile = (Profile)obj?.Profile,
                ApproveEmailCode = obj.ApproveEmailCode,
                ApproveSmsCode = obj.ApproveSmsCode,
                BlockedAt = obj.BlockedAt.ToNullableDateTime(),
                CreatedAt = obj.CreatedAt.ToNullableDateTime(),
                DeletedAt = obj.DeletedAt.ToNullableDateTime(),
                EmailApprovedAt = obj.EmailApprovedAt.ToNullableDateTime(),
                SmsApprovedAt = obj.SmsApprovedAt.ToNullableDateTime(),
                UpdatedAt = obj.UpdatedAt.ToNullableDateTime(),
                Login = obj.Login,
                Password = obj.Password,
                Roles = obj?.Roles?.Select(x => (Role)x)
            };
        }
    }
}
