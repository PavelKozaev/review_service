using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Review.Domain.Services;
using ReviewsWebApplication.Helpers;
using ReviewsWebApplication.Models;

namespace ReviewsWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ReviewsController : ControllerBase
    {

        private readonly ILogger<ReviewsController> _logger;
        private readonly IReviewsService reviewsService;

        public ReviewsController(ILogger<ReviewsController> logger, IReviewsService reviewService)
        {
            _logger = logger;
            this.reviewsService = reviewService;
        }                

        /// <summary>
        /// Получение всех отзывов по продукту
        /// </summary>
        /// <param name="productId">Id продукта</param>
        /// <returns></returns>
        [HttpGet("Product/{productId}")]
        public async Task<ActionResult<List<ReviewApiModel>>> GetByProductIdAsync(Guid productId)
        {
            try
            {
                var result = await reviewsService.GetByProductIdAsync(productId);
                var reviewApiModels = result.ToReviewApiModels();
                return Ok(reviewApiModels);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return BadRequest(new { Error = e.Message });
            }
        }        

        /// <summary>
        /// Удаление отзыва по id
        /// </summary>
        /// <param name="reviewId">Id продукта</param>
        /// <returns></returns>
        [Authorize]
        [HttpDelete("{reviewId}")]
        public async Task<ActionResult<bool>> DeleteAsync(Guid reviewId)
        {
            try
            {
                var result = await reviewsService.TryDeleteAsync(reviewId);
                if(result)
                    return Ok();
                return BadRequest(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return BadRequest(new { Error = e.Message });
            }
        }

        /// <summary>
        /// Получение рейтинга продукта
        /// </summary>
        /// <param name="productId">Id продукта</param>
        /// <returns></returns>
        [HttpGet("{productId}")]
        public async Task<ActionResult<RatingApiModel>> GetRatingByProductIdAsync(Guid productId)
        {
            try
            {
                var (averageGrade, reviewsCount) = await reviewsService.GetRatingByProductIdAsync(productId);

                var rating = new RatingApiModel
                {                    
                    ProductId = productId,
                    AverageGrade = averageGrade,
                    ReviewsCount = reviewsCount
                };

                return Ok(rating);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return BadRequest(new { Error = e.Message });
            }
        }

        /// <summary>
        /// Добавление нового отзыва
        /// </summary>
        /// <param name="productId">Id продукта</param>
        /// <param name="userId">Id пользователя</param>
        /// <param name="text">Текст отзыва</param>
        /// <param name="grade">Оценка</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ReviewApiModel>> CreateAsync(Guid productId, Guid userId, string text, int grade)
        {
            try
            {
                var result = await reviewsService.CreateAsync(productId, userId, text, grade);
                var reviewApiModel = result.ToReviewApiModel();
                return Ok(reviewApiModel);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return BadRequest(new { Error = e.Message });
            }
        }
    }
}