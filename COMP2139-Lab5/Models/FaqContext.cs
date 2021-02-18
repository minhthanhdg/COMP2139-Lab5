using System;
using Microsoft.EntityFrameworkCore;

namespace COMP2139_Lab5.Models
{
    public class FaqContext : DbContext
    {
        public FaqContext(DbContextOptions<FaqContext> options)
            : base(options) { }

        public DbSet<FAQ> FAQs { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = "cs", Name = "c#" },
                new Topic { TopicId = "js", Name = "JavaScript" },
                new Topic { TopicId = "boot", Name = "Bootstrap" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "gen", Name = "General" },
                new Category { CategoryId = "hist", Name = "History" }
            );

            modelBuilder.Entity<FAQ>().HasData(
                new FAQ
                {
                    Id = 1,
                    Question = "What is C#",
                    Answer = "A general purpose object-oriented language that use concise java-like syntax",
                    TopicId = "cs",
                    CategoryId = "gen"
                },
                new FAQ
                {
                    Id = 2,
                    Question = "What is C#",
                    Answer = "A general purpose object-oriented language that use concise java-like syntax",
                    TopicId = "boot",
                    CategoryId = "gen"
                },
                new FAQ
                {
                    Id = 3,
                    Question = "What is C#",
                    Answer = "A general purpose object-oriented language that use concise java-like syntax",
                    TopicId = "cs",
                    CategoryId = "hist"
                }

                );
        }
    }
}
