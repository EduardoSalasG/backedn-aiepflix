using backedn_aiepflix.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backedn_aiepflix
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var roleAdmin = new IdentityRole() 
            {
                Id = "91fcea67-43eb-4ece-8e5a-c0f32c3bbff5",
                Name = "admin",
                NormalizedName = "admin"
            };
            builder.Entity<IdentityRole>().HasData(roleAdmin);
            base.OnModelCreating(builder);
        }


        public DbSet<Pelicula> Peliculas { get; set; }

    }
}
