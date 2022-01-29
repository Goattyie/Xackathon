using AutoMapper;
using Xackathon.Bll.Model;
using Xackathon.Web.Models;

namespace Xackathon.Web
{
    public class Auto
    {
        public static Mapper Mapper { get; set; }

        static Auto()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MediaContentForm, MediaContentDomainModel>();
                cfg.CreateMap<MediaContentDomainModel, MediaContentViewModel>();
                cfg.CreateMap<ProblemCategoryDomainModel, ProblemCategoryViewModel>();
                cfg.CreateMap<ProblemCategoryViewModel, ProblemCategoryDomainModel>();
                cfg.CreateMap<ProfileDomainModel, ProfileViewModel>();
            });

            Mapper = new Mapper(config);
        }
    }
}
