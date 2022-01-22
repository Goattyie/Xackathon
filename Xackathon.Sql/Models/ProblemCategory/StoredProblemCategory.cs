namespace Xackathon.Dal.Models
{
    public class StoredProblemCategory
    {
        public long Id { get; set; }
        public long CategoryProblemId { get; set; }
        public long StoredRequestId { get; set; }
    }
}
