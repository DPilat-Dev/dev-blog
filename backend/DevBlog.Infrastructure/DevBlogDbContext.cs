using DevBlog.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class DevBlogDbContext : IdentityDbContext<User>
{
    public DevBlogDbContext(DbContextOptions<DevBlogDbContext> options) : base(options) { }

    public DbSet<BlogPost> BlogPosts { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<BlogPost>()
            .HasOne(p => p.Author)
            .WithMany()
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}