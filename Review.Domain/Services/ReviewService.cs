using Review.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Review.Domain.Services
{
    public class ReviewService : IReviewService
    {
        private readonly DataBaseContext databaseContext;

        public ReviewService(DataBaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public async Task<List<Feedback>> GetFeedbacksByProductIdAsync(int productId)
        {
            return await databaseContext.Feedbacks.Where(x => x.ProductId == productId).ToListAsync();
        }

        public async Task<IEnumerable<Feedback?>> GetFeedbackAsync(int feedbackId)
        {
            return await databaseContext.Feedbacks.Where(x => x.Id == feedbackId).ToListAsync();
        }

        public async Task<bool> TryToDeleteFeedbackAsync(int feedbackId)
        {
            try
            {
                var feedback = await databaseContext.Feedbacks.Where(x => x.Id == feedbackId).FirstOrDefaultAsync();
                databaseContext.Feedbacks.Remove(feedback!);
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
