namespace Xackathon.Dal.Models
{
    public class ProblemCategory
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string MnemonicName { get; set; }
        public string HashTag { get; set; }
        public string Icon { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        
        public IEnumerable<Request> Requests { get; set; }
    }
}
