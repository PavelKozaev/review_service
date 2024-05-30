namespace Review.Domain.Services
{
    public interface IReviewsService
    {      
        /// <summary>
        /// Получение всех отзывов по продукту
        /// </summary>
        /// <param name="productId">Id продукта</param>
        /// <returns></returns>
        Task<List<Models.Review>> GetByProductIdAsync(Guid productId);        

        /// <summary>
        /// Удаление отзыва
        /// </summary>
        /// <param name="reviewId">Id отзыва</param>
        /// <returns></returns>
        Task<bool> TryDeleteAsync(Guid reviewId);

        /// <summary>
        /// Получение рейтинга продукта
        /// </summary>
        /// <param name="productId">Id продукта</param>
        /// <returns></returns>
        Task<(double averageGrade, int reviewsCount)> GetRatingByProductIdAsync(Guid productId);

        /// <summary>
        /// Добавление нового отзыва
        /// </summary>
        /// <param name="productId">Id продукта</param>
        /// <param name="userId">Id пользователя</param>
        /// <param name="text">Текст отзыва</param>
        /// <param name="grade">Оценка</param>
        /// <returns></returns>
        Task<Models.Review> CreateAsync(Guid productId, Guid userId, string? text, int grade);
    }
}
