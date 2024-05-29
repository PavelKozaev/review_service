using Review.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Review.Domain.Services
{
    public class ReviewsService : IReviewsService
    {
        private readonly DataBaseContext databaseContext;

        public ReviewsService(DataBaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }                

        public async Task<List<Models.Review>> GetByProductIdAsync(Guid productId)
        {
            return await databaseContext.Reviews.Where(x => x.ProductId == productId && x.Status != Status.Deleted).ToListAsync();
        }        

        public async Task<bool> TryDeleteAsync(Guid reviewId)
        {
            try
            {
                var review = await databaseContext.Reviews.FirstOrDefaultAsync(x => x.Id == reviewId);
                if (review != null)
                {
                    review.Status = Status.Deleted;
                }                
                await databaseContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<string> GetRatingByProductIdAsync(Guid productId)
        {
            var reviews = await databaseContext.Reviews.Where(x => x.ProductId == productId && x.Status != Status.Deleted).ToListAsync();
            var productRating = reviews.Average(x => (double)x.Grade);
            return productRating.ToString("0.00");
        }
    }
}
