using Microsoft.EntityFrameworkCore;
using Review.Domain.Helper;

namespace Review.Domain
{
    public class DataBaseContext: DbContext
    {
        public DbSet<Models.Review> Reviews { get; set; }
        
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var reviews = Initialization.SetReviews();      
            modelBuilder.Entity<Models.Review>().HasData(reviews);
        }
    }
}
