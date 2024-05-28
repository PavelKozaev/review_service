﻿using Microsoft.EntityFrameworkCore;
using Review.Domain.Helper;
using Review.Domain.Models;

namespace Review.Domain
{
    public class DataBaseContext: DbContext
    {

        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Models.Review> Reviews { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Review>()
                .HasOne(p => p.Rating)
                .WithMany(t => t.Reviews)
                .HasForeignKey(p => p.RatingId)
                .OnDelete(DeleteBehavior.Cascade);

            var reviews = Initialization.SetReviews();
            var ratings = Initialization.SetRatings(reviews);
            Initialization.AssignRatingsToReviews(reviews, ratings);

            modelBuilder.Entity<Models.Review>().HasData(reviews);
            modelBuilder.Entity<Rating>().HasData(ratings);



            Login[] login = Initialization.SetLogins();
            modelBuilder.Entity<Login>().HasData(login);
        }
    }
}
