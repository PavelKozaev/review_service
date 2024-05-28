﻿using Review.Domain.Models;

namespace Review.Domain.Helper
{
    public static class Initialization
    {
        private const string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        public static List<Models.Review> SetReviews()
        {
            var reviewCount = 100;
            var random = new Random();
            List<Models.Review> reviews = new List<Models.Review>(reviewCount);
            for (int i = 1; i <= reviewCount; i++)
            {
                Models.Review review = CreateReview(random, i);
                reviews.Add(review);
            }
            return reviews;
        }

        public static Models.Review CreateReview(Random random, int reviewId)
        {
            return new Models.Review()
            {
                Id = reviewId,
                CreateDate = DateTime.Now.AddDays(random.Next(-100, 0)),
                Grade = random.Next(0, 6),
                ProductId = random.Next(1, 10),
                Text = loremIpsum.Substring(0, random.Next(20, 100)),
                UserId = random.Next(1, 10),                 
                Status = (Status)random.Next(0, 2)
            };
        }

        public static List<Rating> SetRatings(List<Models.Review> existingReviews)
        {
            var ratingsCount = 100;
            var random = new Random();
            List<Rating> ratings = new List<Rating>(ratingsCount);
            for (int i = 1; i <= ratingsCount; i++)
            {
                Rating rating = CreateRating(random, existingReviews, i);
                ratings.Add(rating);
            }
            return ratings;
        }

        public static Rating CreateRating(Random random, List<Models.Review> existingReviews, int id)
        {            
            int currentProductId = random.Next(1, 10);
            var productReviews = existingReviews.Where(r => r.ProductId == currentProductId).ToList();
            
            double reviewsAverage = productReviews.Any() ? productReviews.Average(x => x.Grade) : 0;

            var rating = new Rating()
            {
                Id = id,
                CreateDate = DateTime.Now.AddDays(random.Next(-100, 0)),
                ProductId = currentProductId,
                Grade = Math.Round(reviewsAverage, 2)
            };
            return rating;
        }

        public static void AssignRatingsToReviews(List<Models.Review> reviews, List<Rating> ratings)
        {            
            foreach (var review in reviews)
            {
                var rating = ratings.FirstOrDefault(r => r.ProductId == review.ProductId);
                if (rating != null)
                {
                    review.RatingId = rating.Id; 
                }
            }
        }

        public static Login[] SetLogins()
        {
            var logins = new List<Login>();
            var admin = new Login()
            {  
                Id = 1,
                UserName = "admin", 
                Password = "admin" 
            };
            logins.Add(admin);
            return logins.ToArray();
        }
    }
}
