namespace Xackathon.Dal.Models
{
    public class Role
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string MnemonicName { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
