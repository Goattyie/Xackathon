namespace Xackathon.Dal.Models
{
    public class Profile
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public IEnumerable<Request> Requests { get; set; }
    }
}
