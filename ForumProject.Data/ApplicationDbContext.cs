using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ForumProject.Data.Models;



namespace ForumProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<Forum> forums { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<PostReply> replies { get; set; }
    }
}
