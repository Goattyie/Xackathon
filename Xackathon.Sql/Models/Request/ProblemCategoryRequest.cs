namespace Xackathon.Dal.Models
{
    public class ProblemCategoryRequest
    {
        public long Id { get; set; }
        public long ProblemCategoryId { get; set; }
        public long ContractorId { get; set; }
        public ProblemCategory ProblemCategory { get; set; }
        public Contractor Contractor { get; set; }
    }
}
