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

        public async Task<bool> AddFeedbackAsync(int productId, int userId, string text, int grade)
        {
            try
            {        
                // Проверяю, существует ли рейтинг
                var rating = await databaseContext.Ratings.FirstOrDefaultAsync(r => r.ProductId == productId);
                if (rating == null)
                {
                    // Если нет, то создаю его
                    rating = new Rating
                    {
                        ProductId = productId,
                        Grade = 0,
                        CreateDate = DateTime.UtcNow
                    };
                    await databaseContext.Ratings.AddAsync(rating);
                    await databaseContext.SaveChangesAsync(); 
                }

                // Создаю новый отзыв
                var feedback = new Feedback
                {
                    ProductId = productId,
                    UserId = userId,
                    Text = text,
                    Grade = grade,
                    CreateDate = DateTime.UtcNow,
                    Status = Status.Actual,
                    RatingId = rating.Id
                };
                await databaseContext.Feedbacks.AddAsync(feedback!);
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
