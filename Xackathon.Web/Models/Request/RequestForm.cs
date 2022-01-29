using Xackathon.Abstractions;
using Xackathon.Bll;
using Xackathon.Bll.Model;

namespace Xackathon.Web.Models
{
    public class RequestForm
    {
        /// <summary>
        /// ФИО пользователя
        /// </summary>
        /// <example>Сергеев Михаил Александрович</example>
        public string FIO { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        /// <example>+380715351234</example>
        public string Phone { get; set; }
        /// <summary>
        /// Ресурс, с которого отправляется заявка
        /// </summary>
        /// <example>telegram</example>
        public string Source { get; set; }
        public IEnumerable<MediaContentForm> Content { get; set; }
        /// <example>[1]</example>
        public IEnumerable<int> ProblemCategories { get; set; }
        /// <summary>
        /// Адрес проблемной ситуации
        /// </summary>
        /// <example>г. Донецк, ул. Панфилова дом 16-а</example>
        public string Location { get; set; }
        /// <summary>
        /// Широта (координата)
        /// </summary>
        /// <example>32</example>
        public float Latitude { get; set; }
        /// <summary>
        /// Долгота (координата)
        /// </summary>
        /// <example>15064</example>
        public float Longitude { get; set; }
        /// <summary>
        /// Описание проблемы
        /// </summary>
        /// <example>Авария на перекрестке</example>
        public string Description { get; set; }

        public static explicit operator RequestFormDomainModel(RequestForm form)
        {
            var domainModel = new RequestFormDomainModel();
            domainModel.FIO = form.FIO;
            domainModel.Phone = form.Phone;
            domainModel.Location = form.Location;
            domainModel.Latitude = form.Latitude;
            domainModel.Longitude = form.Longitude;
            domainModel.Description = form.Description;
            domainModel.Content = Auto.Mapper.Map<IEnumerable<MediaContentDomainModel>>(form.Content);
            domainModel.WatchCount = 0;
            domainModel.CreatedAt = DateTime.Now.ToFormatString();
            domainModel.ProblemCategories = form.ProblemCategories;

            Source temp;
            if (!Enum.TryParse(form.Source, true, out temp))
                throw new Exception(Bll.Resources.Errors.DateNotValid + ": Source");
            domainModel.Source = temp;

            return domainModel;
        }
    }
}
