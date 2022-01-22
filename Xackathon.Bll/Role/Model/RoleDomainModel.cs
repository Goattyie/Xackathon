﻿using Xackathon.Dal.Models;

namespace Xackathon.Bll.Model
{
    public class RoleDomainModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string DeletedAt { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public static explicit operator Role(RoleDomainModel obj)
        {
            return new Role
            {
                Id = obj.Id,
                Title = obj.Title,
                MnemonicName = obj.Slug,
                CreatedAt = DateTime.Parse(obj.CreatedAt).ToUniversalTime(),
                DeletedAt = DateTime.Parse(obj.DeletedAt).ToUniversalTime(),
                UpdatedAt = DateTime.Parse(obj.UpdatedAt).ToUniversalTime(),
            };
        }
    }
}