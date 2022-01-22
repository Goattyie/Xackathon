namespace Xackathon.Dal.Models
{
    public class StoppingRoutePoint
    {
        public long Id { get; set; }
        public long StoppingPointId { get; set; }
        public long TransportRouteId { get; set; }
        public long Position { get; set; }
        public bool IsStart { get; set; }
        public bool IsEnd { get; set; }
    }
}
