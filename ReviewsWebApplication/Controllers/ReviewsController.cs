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
                result.ToReviewApiModels();
                return Ok(result);
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
        public async Task<ActionResult<List<ReviewApiModel>>> DeleteAsync(Guid reviewId)
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
        public async Task<ActionResult<string>> GetRatingByProductIdAsync(Guid productId)
        {
            try
            {
                string result = await reviewsService.GetRatingByProductIdAsync(productId);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return BadRequest(new { Error = e.Message });
            }
        }
    }
}