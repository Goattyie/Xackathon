using Xackathon.Dal.Models;

namespace Xackathon.Bll.Model
{
    public class RegionDomainModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int Positions { get; set; }
        public bool IsActive { get; set; }
        public string DeletedAt { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public static explicit operator Region(RegionDomainModel obj)
        {
            var region = new Region();

            region.Id = obj.Id;
            region.Title = obj.Title;
            region.Positions = obj.Positions;
            region.IsActive = obj.IsActive;
            region.DeletedAt = obj.DeletedAt.ToNullableDateTime();
            region.CreatedAt = obj.DeletedAt.ToNullableDateTime();
            region.UpdatedAt = obj.DeletedAt.ToNullableDateTime();

            return region;
        }
    }
}
