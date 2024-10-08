﻿using Microsoft.AspNetCore.Identity;
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
        public DbSet<News> News { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Dislike> Dislikes { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<UserAchievementsModel> UserAchievements { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Campaign>().HasOne(camp => camp.Category).WithMany(cat => cat.Campaigns).HasForeignKey(camp => camp.CategoryId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Campaign>().HasMany(camp => camp.Comments).WithOne(comm => comm.Campaign).HasForeignKey(comm => comm.CampaignId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Campaign>().HasMany(camp => camp.News).WithOne(n => n.Campaign).HasForeignKey(n => n.CampaignId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Campaign>().HasMany(camp => camp.Rewards).WithOne(rew => rew.Campaign).HasForeignKey(rew => rew.CampaignId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Campaign>().HasMany(camp => camp.Ratings).WithOne(r => r.Campaign).HasForeignKey(r => r.CampaignId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Comment>().HasMany(comm => comm.Likes).WithOne(like => like.Comment).HasForeignKey(like => like.CommentId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Comment>().HasMany(comm => comm.Dislikes).WithOne(like => like.Comment).HasForeignKey(like => like.CommentId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<UserAchievementsModel>().HasKey(ua => new { ua.UserId, ua.AchievementId });
            modelBuilder.Entity<UserAchievementsModel>().HasOne(ua => ua.Achievement).WithMany(a => a.UserAchievements).HasForeignKey(ua => ua.AchievementId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<UserAchievementsModel>().HasOne(ua => ua.User).WithMany(a => a.UserAchievements).HasForeignKey(ua => ua.UserId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ApplicationUser>().HasMany(u => u.Campaigns).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ApplicationUser>().HasMany(u => u.Comments).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ApplicationUser>().HasMany(u => u.News).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ApplicationUser>().HasMany(u => u.Likes).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ApplicationUser>().HasMany(u => u.Dislikes).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ApplicationUser>().HasMany(u => u.Ratings).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
