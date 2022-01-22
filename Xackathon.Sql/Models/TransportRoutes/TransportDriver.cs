namespace Xackathon.Dal.Models
{
    public class TransportDriver
    {
        public long Id { get; set; }
        public long RouteId { get; set; }
        public long UserId { get; set; }
        public DateTime WorkDate { get; set; }
    }
}
