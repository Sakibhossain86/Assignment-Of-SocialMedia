using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace SocialMediaPlatform.Model
{
    public class MediaDbContext : DbContext
    {
        public MediaDbContext(DbContextOptions<MediaDbContext> options): base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasMany(user => user.Posts)  
            .WithOne(post => post.User)  
            .HasForeignKey(post => post.UserId);

         
        }

    }
}
