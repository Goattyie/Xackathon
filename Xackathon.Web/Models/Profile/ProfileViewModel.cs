namespace Xackathon.Web.Models
{
    public class ProfileViewModel
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Email { get; set; }
        public IEnumerable<RequestObjectViewModel> Requests { get; set; }
        public IEnumerable<StoredRequestViewModel> StoredRequests { get; set; }
        public bool IsNotificationSms { get; set; }
        public bool IsAnonymousRequests { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
