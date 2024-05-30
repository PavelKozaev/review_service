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
            return await databaseContext.Reviews.
                Where(x => x.ProductId == productId && x.Status != Status.Deleted).
                ToListAsync();
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

        public async Task<(double averageGrade, int reviewsCount)> GetRatingByProductIdAsync(Guid productId)
        {
            var reviews = await databaseContext.Reviews
                .Where(x => x.ProductId == productId && x.Status != Status.Deleted)
                .ToListAsync();

            // Если нет отзывов, возвращаю кортеж с нулевыми значениями.
            if (!reviews.Any())
                return (0, 0);

            var averageGrade = reviews.Average(x => x.Grade);
            averageGrade = Math.Round(averageGrade, 2); // Округляю до двух десятичных знаков

            var reviewsCount = reviews.Count;

            return (averageGrade, reviewsCount);
        }

        public async Task<Models.Review> CreateAsync(Guid productId, Guid userId, string? text, int grade)
        {

            var review = new Models.Review
            {
                ProductId = productId,
                UserId = userId,
                Text = text,
                Grade = grade,
                CreateDate = DateTime.UtcNow,
                Status = Status.Actual,
            };

            await databaseContext.Reviews.AddAsync(review!);
            await databaseContext.SaveChangesAsync();
            return review;
        }
    }
}
