using Review.Domain.Models;

namespace Review.Domain.Services
{
    public interface IReviewsService
    {
        /// <summary>
        /// Получение всех отзывов 
        /// </summary>
        /// <returns></returns>
        Task<List<Models.Review>> GetAll();

        /// <summary>
        /// Получение всех отзывов по продукту
        /// </summary>
        /// <param name="productId">Id продукта</param>
        /// <returns></returns>
        Task<List<Models.Review>> GetByProductIdAsync(int productId);

        /// <summary>
        /// Получение отзыва
        /// </summary>
        /// <param name="reviewId">Id отзыва</param>
        /// <returns></returns>
        Task<IEnumerable<Models.Review?>> GetAsync(int reviewId);

        /// <summary>
        /// Удаление отзыва
        /// </summary>
        /// <param name="reviewId">Id отзыва</param>
        /// <returns></returns>
        Task<bool> TryToDeleteAsync(int reviewId);
    }
}
