using CourseWork.DAL.Identity;
using CourseWork.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.DAL.DbContext
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {    }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Bonus> Bonuses { get; set; }
        public DbSet<Campain> Campains { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<PicturesGalary> PicturesGalaries { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CampainTag>().HasKey(sc => new { sc.CampainId, sc.TagId });
            base.OnModelCreating(modelBuilder);
        }
    }

}
