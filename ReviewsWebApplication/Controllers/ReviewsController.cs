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
        /// ��������� ���� ������� �� ��������
        /// </summary>
        /// <param name="productId">Id ��������</param>
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
        /// �������� ������ �� id
        /// </summary>
        /// <param name="reviewId">Id ��������</param>
        /// <returns></returns>
        
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
        /// ��������� �������� ��������
        /// </summary>
        /// <param name="productId">Id ��������</param>
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
        /// ���������� ������ ������
        /// </summary>
        /// <param name="productId">Id ��������</param>
        /// <param name="userId">Id ������������</param>
        /// <param name="text">����� ������</param>
        /// <param name="grade">������</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ReviewApiModel>> CreateAsync([FromBody] ReviewApiModel review)
        {
            try
            {
                var result = await reviewsService.CreateAsync(review.ProductId, review.UserId, review.Text, review.Grade);                
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