using Xackathon.Bll.Model;

namespace Xackathon.Web.Models
{
    public class RegionForm
    {
        /// <summary>
        /// The sizes the product is available in
        /// </summary>
        /// <example>Hello world</example>
        public string Title { get; set; }
        /// <summary>
        /// The sizes the product is available in
        /// </summary>
        /// <example>3</example>
        public int Positions { get; set; }
        /// <summary>
        /// The sizes the product is available in
        /// </summary>
        /// <example>true</example>
        public bool IsActive { get; set; }
        /// <summary>
        /// The sizes the product is available in
        /// </summary>
        /// <example>2022-10-01 16:32:00</example>
        public string DeletedAt { get; set; }
        /// <summary>
        /// The sizes the product is available in
        /// </summary>
        /// <example>2022-10-01 16:32:00</example>
        public string CreatedAt { get; set; }
        /// <summary>
        /// The sizes the product is available in
        /// </summary>
        /// <example>2022-10-01 16:32:00</example>
        public string UpdatedAt { get; set; }

        public static explicit operator RegionDomainModel(RegionForm obj)
        {
            return new RegionDomainModel
            {
                Title = obj.Title,
                Positions = obj.Positions,
                DeletedAt = obj.DeletedAt,
                CreatedAt = obj.CreatedAt,
                UpdatedAt = obj.UpdatedAt,
            };
        }
    }
}
