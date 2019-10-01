using Acme.AppCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.AppData
{
    public class ActivitySignupContext : DbContext
    {
        public ActivitySignupContext(DbContextOptions<ActivitySignupContext> options) : base(options)
        {
            
        }

        public DbSet<Activity> activities { get; set; }
        public DbSet<Signups> signups { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Activity>(ConfigureActivity);
            builder.Entity<Signups>(ConfigureSignups);

        }

        private void ConfigureActivity(EntityTypeBuilder<Activity> builder)
        {
            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasKey(ci => ci.Id);

        }

        private void ConfigureSignups(EntityTypeBuilder<Signups> builder)
        {
            builder.Property(s => s.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.Phone)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.Comment)                
                .HasMaxLength(200);

            builder.HasOne(s => s.Activity)
                .WithMany()
                .HasForeignKey(s => s.ActivityId);

        }
    }
}
