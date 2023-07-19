

using eSocial.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace eSocial.Dal
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Contexto).Assembly);

            modelBuilder.Entity<Post>().HasData(
                new Post { Id = 1, Content = "Fullstack Developer", CreatedAt = DateTime.Now, LastUpdate = DateTime.Now },
                new Post { Id = 2, Content = "Blazor Developer", CreatedAt = DateTime.Now, LastUpdate = DateTime.Now },
                new Post { Id = 3, Content = ".Net Developer", CreatedAt = DateTime.Now, LastUpdate = DateTime.Now }
            );
        }

    }
}