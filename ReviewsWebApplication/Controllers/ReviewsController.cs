using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Review.Domain.Models;
using Review.Domain.Services;

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
        /// ��������� ���� �������
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<Review.Domain.Models.Review>>> GetAllAsync()
        {
            try
            {
                var result = await reviewsService.GetAll();
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return BadRequest(new { Error = e.Message });
            }
        }

        /// <summary>
        /// ��������� ���� ������� �� ��������
        /// </summary>
        /// <param name="productId">Id ��������</param>
        /// <returns></returns>
        [HttpGet("Product/{productId}")]
        public async Task<ActionResult<List<Review.Domain.Models.Review>>> GetByProductIdAsync(int productId)
        {
            try
            {
                var result = await reviewsService.GetByProductIdAsync(productId);
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
        /// <param name="reviewId">Id ��������</param>
        /// <returns></returns>
        [HttpGet("{reviewId}")]
        public async Task<ActionResult<List<Review.Domain.Models.Review>>> GetAsync(int reviewId)
        {
            try
            {
                var result = await reviewsService.GetAsync(reviewId);
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
        /// <param name="reviewId">Id ��������</param>
        /// <returns></returns>
        [Authorize]
        [HttpDelete]
        public async Task<ActionResult<List<Review.Domain.Models.Review>>> DeleteAsync(int reviewId)
        {
            try
            {
                var result = await reviewsService.TryToDeleteAsync(reviewId);
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