using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xackathon.Dal.Models;

namespace Xackathon.Bll.Model
{
    public class ProfileDomainModel
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public IEnumerable<RequestDomainModel> Requests { get; set; }
        public IEnumerable<StoredRequestDomainModel> StoredRequests { get; set; }
        public bool IsNotificationSms { get; set; }
        public bool IsNotificationEmail { get; set; }
        public bool IsAnonymousRequests { get; set; }
        public string Phone { get; set; }
        public string DeletedAt { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public static explicit operator Profile(ProfileDomainModel obj)
        {
            return obj != null ? new Profile
            {
                Id = obj.Id,
                UserId = obj.UserId,
                Name = obj.Name,
                Rating = obj.Rating,
                Email = obj.Email,
                CreatedAt = obj.CreatedAt.ToDateTime(),
                DeletedAt = obj.DeletedAt.ToDateTime(),
                UpdatedAt = obj.UpdatedAt.ToDateTime(),
                Location = obj.Location,
                IsNotificationEmail = obj.IsNotificationEmail,
                IsNotificationSms = obj.IsNotificationSms,
                Phone = obj.Phone,
                Requests = obj.Requests.Select(x => (Request)x),
                IsAnonymousRequests = obj.IsAnonymousRequests,
                StoredRequests = obj.StoredRequests.Select(x => (StoredRequest)x),
            } : null;
        }
    }
}
