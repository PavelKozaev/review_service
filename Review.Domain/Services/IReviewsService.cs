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
        Task<bool> TryToDeleteAsync(Guid reviewId);
    }
}
