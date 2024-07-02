using Review.Domain.Models;

namespace Review.Domain.Helper
{
    public static class Initialization
    {
        private const string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        public static List<Models.Review> SetReviews()
        {
            var reviewCount = 100;
            var reviews = new List<Models.Review>(reviewCount);
            var random = new Random();
            var productIds = Enumerable.Range(0, 10).Select(_ => Guid.NewGuid()).ToArray();

            for (int i = 0; i < reviewCount; i++)
            {
                Models.Review review = CreateReview(random, productIds[random.Next(productIds.Length)]);
                reviews.Add(review);
            }

            return reviews;
        }

        public static Models.Review CreateReview(Random random, Guid productId)
        {
            return new Models.Review()
            {
                Id = Guid.NewGuid(),
                ProductId = productId, 
                UserId = Guid.NewGuid(),
                Text = loremIpsum.Substring(0, random.Next(20, 100)),
                Grade = random.Next(1, 6), 
                CreateDate = DateTime.Now.AddDays(random.Next(-100, 0)),                             
                Status = (Status)random.Next(1, 3) 
            };
        }
    }
}
