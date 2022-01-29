using AutoMapper;
using Xackathon.Bll.Model;
using Xackathon.Dal.Models;

namespace Xackathon.Bll
{
    public class Auto
    {
        public static Mapper Mapper { get; set; }

        static Auto()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MediaContentDomainModel, MediaContent>();
                cfg.CreateMap<MediaContent, MediaContentDomainModel>();
                cfg.CreateMap<ProblemCategoryDomainModel, ProblemCategory>();
                cfg.CreateMap<Dal.Models.Profile, ProfileDomainModel>();
            });

            Mapper = new Mapper(config);
        }
    }
}

