using DevBlog.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevBlog.Infastructure;

public class DevBlogDbContext : DbContext
{
    public DevBlogDbContext(DbContextOptions<DevBlogDbContext> options) : base(options) { }

    public DbSet<BlogPost> BlogPosts {get;set;}
}
