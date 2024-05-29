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

        public async Task<bool> TryToDeleteAsync(Guid reviewId)
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
    }
}
