namespace Xackathon.Dal.Models
{
    public class StoredProblemCategory
    {
        public long Id { get; set; }
        public long ProblemCategoryId { get; set; }
        public long StoredRequestId { get; set; }
        public ProblemCategory ProblemCategory { get; set; }
        public StoredRequest StoredRequest { get; set; }
    }
}
