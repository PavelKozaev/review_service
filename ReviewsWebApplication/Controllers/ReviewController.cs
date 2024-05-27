using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Review.Domain.Models;
using Review.Domain.Services;

namespace ReviewsWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ReviewController : ControllerBase
    {

        private readonly ILogger<ReviewController> _logger;
        private readonly IReviewService reviewService;

        public ReviewController(ILogger<ReviewController> logger, IReviewService reviewService)
        {
            _logger = logger;
            this.reviewService = reviewService;
        }

        /// <summary>
        /// Получение всех отзывов по продукту
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetFeedbacksByProductId")]
        public async Task<ActionResult<List<Feedback>>> GetAllFeedbacksAsync(int productId)
        {
            try
            {
                var result = await reviewService.GetFeedbacksByProductIdAsync(productId);
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return BadRequest(new { Error = e.Message });
            }
        }

        /// <summary>
        /// Получение отзыва
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetFeedback")]
        public async Task<ActionResult<List<Feedback>>> GetFeedbackAsync(int feedbackId)
        {
            try
            {
                var result = await reviewService.GetFeedbackAsync(feedbackId);
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
        /// <returns></returns>
        
        [HttpDelete("DeleteFeedback")]
        public async Task<ActionResult<List<Feedback>>> DeleteFeedbackAsync(int feedbackId)
        {
            try
            {
                var result = await reviewService.TryToDeleteFeedbackAsync(feedbackId);
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
    }
}