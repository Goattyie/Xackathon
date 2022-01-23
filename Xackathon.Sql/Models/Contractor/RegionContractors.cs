namespace Xackathon.Dal.Models
{
    public class RegionContractors
    {
        public long Id { get; set; }
        public long ContractorId { get; set; }
        public long RegionId { get; set; }
        public Contractor Contractor { get; set; }
        public Region Region { get; set; }
    }
}
