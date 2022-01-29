using Xackathon.Bll;
using Xackathon.Bll.Model;

namespace Xackathon.Web.Models
{
    public class ProblemCategoryForm
    {
        /// <summary>
        /// Название категории
        /// </summary>
        /// <example>Пробка на дороге</example>
        public string Title { get; set; }
        /// <summary>
        /// Мнемоническое имя
        /// </summary>
        /// <example>probka_na_doroge</example>
        public string MnemonicName { get; set; }
        /// <summary>
        /// Тег
        /// </summary>
        /// <example>#probka</example>
        public string HashTag { get; set; }
        /// <summary>
        /// url на изображение иконки
        /// </summary>
        /// <example>https://mywebicons.ru/i/jpg/98a7d78e623964e6b68aa450c02366b7.jpg</example>
        public string Icon { get; set; }
        /// <summary>
        /// Рейтинг проблемы
        /// </summary>
        /// <example>3</example>
        public int Rating { get; set; }

        public static explicit operator ProblemCategoryDomainModel(ProblemCategoryForm obj)
        {
            return new ProblemCategoryDomainModel
            {
                Title = obj.Title,
                MnemonicName = obj.MnemonicName,
                HashTag = obj.HashTag,
                Icon = obj.Icon,
                Rating = obj.Rating,
                CreatedAt = DateTime.Now.ToFormatString(),
            };
        }
    }
}
