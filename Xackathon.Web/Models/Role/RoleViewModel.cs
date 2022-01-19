namespace Xackathon.Models
{
    public enum RoleTitle
    {
        Guest,
        User,
        Administrator,
        Constractor,
        ConstractorExecutive,
        ConstractorSupervising,
        Technical
    }
    public class RoleViewModel
    {
        public long Id { get; set; }
        public RoleTitle Title { get; set; }
        public string Slug { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
