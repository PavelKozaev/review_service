using ReviewsWebApplication.Models;

namespace ReviewsWebApplication.Helpers
{
    public static class Mapping
    {
        public static List<ReviewApiModel> ToReviewApiModels(this List<Review.Domain.Models.Review> reviews)
        {
            var reviewApiModels = new List<ReviewApiModel>();
            foreach (var review in reviews)
            {
                reviewApiModels.Add(ToReviewApiModel(review));
            }
            return reviewApiModels;
        }

        public static ReviewApiModel ToReviewApiModel(this Review.Domain.Models.Review review)
        {
            return new ReviewApiModel
            {
                Id = review.Id,
                ProductId = review.ProductId,
                UserId = review.UserId,
                Text = review.Text,
                CreateDate = review.CreateDate,
                Grade = review.Grade                              
            };
        }
    }
}