﻿using Xackathon.Bll.Model;

namespace Xackathon.Web.Models
{
    public class ProblemCategoryViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string MnemonicName { get; set; }
        public string HashTag { get; set; }
        public string Icon { get; set; }
        public int Rating { get; set; }
        public bool IsActive { get; set; }
        public bool IsVisible { get; set; }
        /// <example>2022-10-01 16:32:00</example>
        public string DeletedAt { get; set; }
        /// <example>2022-10-01 16:32:00</example>
        public string CreatedAt { get; set; }
        /// <example>2022-10-01 16:32:00</example>
        public string UpdatedAt { get; set; }

        public static explicit operator ProblemCategoryDomainModel(ProblemCategoryViewModel obj)
        {
            return new ProblemCategoryDomainModel
            {
                Id = obj.Id,
                Title = obj.Title,
                MnemonicName = obj.MnemonicName,
                HashTag = obj.HashTag,
                Icon = obj.Icon,
                Rating = obj.Rating,
                IsActive = obj.IsActive,
                CreatedAt = obj.CreatedAt,
                UpdatedAt = obj.UpdatedAt,
                DeletedAt = obj.DeletedAt,
            };
        } 
    }
}
