using Xackathon.Bll.Model;

namespace Xackathon.Web.Models
{
    public class UserForm
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public static explicit operator UserDomainModel(UserForm obj)
        {
            return new UserDomainModel
            {
                Password = obj.Password,
                Login = obj.Login
            };
        }
    }
}
