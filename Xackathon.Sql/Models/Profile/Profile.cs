namespace Xackathon.Dal.Models
{
    public class Profile
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public bool IsNotificationEmail { get; set; }
        public bool IsNotificationSms { get; set; }
        public bool IsAnonymousRequests { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }
        public IEnumerable<Request> Requests { get; set; }
        public IEnumerable<StoredRequest> StoredRequests { get; set; }
    }
}
