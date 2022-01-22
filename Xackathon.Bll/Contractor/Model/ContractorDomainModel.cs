using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xackathon.Dal.Models;

namespace Xackathon.Bll.Contractor.Model
{

    public class ContractorDomainModel
    {
        public long Id { get; set; }
        public long RequestId { get; set; }
        public long ConstractorId { get; set; }
        public DateTime EstimatedTaskProcessingDate { get; set; }
        public DateTime ActualTaskProcessingDate { get; set; }
        public string Description { get; set; }
        public string ResponsiblePerson { get; set; }
        public string ContactPhone { get; set; }
        public OrganizationType Type { get; set; }
        public IEnumerable<MediaContent> Attachments { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
