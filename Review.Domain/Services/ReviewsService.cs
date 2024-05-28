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

        public async Task<List<Models.Review>> GetAll()
        {
            return await databaseContext.Reviews.ToListAsync();
        }

        public async Task<List<Models.Review>> GetByProductIdAsync(int productId)
        {
            return await databaseContext.Reviews.Where(x => x.ProductId == productId && x.Status != Status.Deleted).ToListAsync();
        }

        public async Task<IEnumerable<Models.Review?>> GetAsync(int reviewId)
        {
            return await databaseContext.Reviews.Where(x => x.Id == reviewId).ToListAsync();
        }

        public async Task<bool> TryToDeleteAsync(int reviewId)
        {
            try
            {
                var review = await databaseContext.Reviews.FirstOrDefaultAsync(x => x.Id == reviewId);
                databaseContext.Reviews.Remove(review!);
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
