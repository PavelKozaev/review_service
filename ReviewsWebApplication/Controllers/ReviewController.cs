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
        /// ��������� ���� ������� �� ��������
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
        /// ��������� ������
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
        /// �������� ������ �� id
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

        /// <summary>
        /// ���������� ������
        /// </summary>
        /// <returns></returns>

        [HttpPost("AddFeedback")]
        public async Task<ActionResult<List<Feedback>>> AddFeedbackAsync(int productId, int userId, string text, int grade)
        {
            try
            {
                var result = await reviewService.AddFeedbackAsync(productId, userId, text, grade);
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