using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        /// ��������� ���� ������� �� ��������
        /// </summary>
        /// <param name="productId">Id ��������</param>
        /// <returns></returns>
        [HttpGet("{productId}")]
        public async Task<ActionResult<List<Review.Domain.Models.Review>>> GetByProductIdAsync(Guid productId)
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
        /// �������� ������ �� id
        /// </summary>
        /// <param name="reviewId">Id ��������</param>
        /// <returns></returns>
        [Authorize]
        [HttpDelete("{reviewId}")]
        public async Task<ActionResult<List<Review.Domain.Models.Review>>> DeleteAsync(Guid reviewId)
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