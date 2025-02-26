using Microsoft.EntityFrameworkCore;
using FilmNotebook.Models;

namespace FilmNotebook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FilmList> FilmLists { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FilmCategory> FilmCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmCategory>()
                .HasKey(fc => new { fc.FilmId, fc.CategoryId }); // Definicja klucza złożonego
        }
    }
}
