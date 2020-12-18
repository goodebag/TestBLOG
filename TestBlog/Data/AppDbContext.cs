using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog.Models;

namespace TestBlog.Data
{
    public class AppDbContext : IdentityDbContext<myIdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Like> GetLikes  { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<EmailNotification> EmailAddresses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EmailNotification>().HasData(
             new EmailNotification
             {
                 EmailAddress= "egbule.Smart@gmail.com"
             }
             );
        }
    }
}
