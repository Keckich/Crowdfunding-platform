using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Сrowdfunding.Models;

namespace Сrowdfunding.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Campaign>().HasOne(camp => camp.Category).WithMany(cat => cat.Campaigns).HasForeignKey(camp => camp.CategoryId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Campaign>().HasMany(camp => camp.Comments).WithOne(comm => comm.Campaign).HasForeignKey(comm => comm.CampaignId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
