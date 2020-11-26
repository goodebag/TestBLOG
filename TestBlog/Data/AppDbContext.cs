using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog.Models;

namespace TestBlog.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Like> GetLikes  { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Post>().HasData(
             new Post
             {
                 PostId = 1,
                 Headline = "End Swat: Nigerians reject police unit replacing",
                 postWriteUp = "Nigerians are outraged by the unveiling of a new police unit to replace a " +
                 "notorious agency that was disbanded following public outcry over its alleged human rights abuses. he head of the police Mohammed Adamu announced that" +
                 " Swat would carry out the duties which were done by the Special Anti Robbery Squad(Sars). But many are using the hashtag #EndSwat on Twitter to oppose the new unit." +
                "They see the changes as not enough to reform the police.",

                 Date = DateTime.Now,
                 Discription = Category.Lifestyle,
                 Photopath = "no to swat.jpg"
                 //GetReaction = Reaction.Love,
                 //Comment ="I love this Reney is on fire"
             }
             );
        }
    }
}
