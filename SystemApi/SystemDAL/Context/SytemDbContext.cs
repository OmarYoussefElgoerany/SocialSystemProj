using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using SystemApi.SystemDAL.Models;

namespace SystemApi.SystemDAL.Context
{
    public class SytemDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public SytemDbContext()
        {
                
        }
        public SytemDbContext(DbContextOptions<SytemDbContext> options) : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
              new User { Id = 1, UserName = "Omar" },
              new User { Id = 2, UserName = "Ahmed" },
              new User { Id = 3, UserName = "Karim" })
;
            // Add more seed data for Posts, Reviews, and Stories here...

            // Seed Reviews
            modelBuilder.Entity<Review>().HasData(
                new Review { Id = 1, Rate = 4, Comment = "Good post", PostId = 1 },
                new Review { Id = 2, Rate = 5, Comment = "Excellent post", PostId = 2 },
                new Review { Id = 3, Rate = 3, Comment = "Average post", PostId = 3 },
                new Review { Id = 4, Rate = 2, Comment = "Poor post", PostId = 4 },
                new Review { Id = 5, Rate = 1, Comment = "Terrible post", PostId = 5 },
                new Review { Id = 6, Rate = 4, Comment = "Good post", PostId = 6 },
                new Review { Id = 7, Rate = 5, Comment = "Excellent post", PostId = 7 },
                new Review { Id = 8, Rate = 3, Comment = "Average post", PostId = 8 },
                new Review { Id = 9, Rate = 2, Comment = "Poor post", PostId = 9 },
                new Review { Id = 10, Rate = 1, Comment = "Terrible post", PostId = 10 }
           
            );
            // Seed Posts
            modelBuilder.Entity<Post>().HasData(
                new Post { Id = 1, Name = "post6", UserId = 1 },
                new Post { Id = 2, Name = "post7", UserId = 1 },
                new Post { Id = 3, Name = "post8", UserId = 1 },
                new Post { Id = 4, Name = "post9", UserId = 1 },
                new Post { Id = 5, Name = "post10", UserId = 2},
                new Post { Id = 6, Name = "post11", UserId = 2},
                new Post { Id = 7, Name = "post12", UserId = 2 },
                new Post { Id = 8, Name = "post13", UserId = 3 },
                new Post { Id = 9, Name = "post14", UserId = 3},
                new Post { Id = 10, Name = "post15", UserId = 3 }
            );





            // Seed Stories
            modelBuilder.Entity<Story>().HasData(
                new Story { Id = 6, Name = "story6",   UserId = 1 },
                new Story { Id = 7, Name = "story7",   UserId =  1},
                new Story { Id = 8, Name = "story8", UserId = 1 },
                new Story { Id = 9, Name = "story9",   UserId = 1 },
                new Story { Id = 10, Name = "story10", UserId =  2},
                new Story { Id = 11, Name = "story11", UserId = 2 },
                new Story { Id = 12, Name = "story12", UserId = 2 },
                new Story { Id = 13, Name = "story13", UserId = 2 },
                new Story { Id = 14, Name = "story14", UserId = 2 },
                new Story { Id = 15, Name = "story15", UserId =  3},
                new Story { Id = 1, Name = "story1",   UserId = 3},
                new Story { Id = 2, Name = "story2",   UserId = 3 },
                new Story { Id = 3, Name = "story3",   UserId =  3},
                new Story { Id = 4, Name = "story4",   UserId =  1},
                new Story { Id = 5, Name = "story5",   UserId =  1}
            );
        }
    }
}
