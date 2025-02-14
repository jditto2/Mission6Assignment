using Microsoft.EntityFrameworkCore;

namespace Mission6Assignment.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Title = "Inception",
                    Category = "Sci-Fi",
                    Director = "Christopher Nolan",
                    Year = 2010,
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = "Mind-blowing!"
                },
                new Movie
                {
                    MovieId = 2,
                    Title = "The Dark Knight",
                    Category = "Action",
                    Director = "Christopher Nolan",
                    Year = 2008,
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = "Great Batman movie"
                },
                new Movie
                {
                    MovieId = 3,
                    Title = "Interstellar",
                    Category = "Sci-Fi",
                    Director = "Christopher Nolan",
                    Year = 2014,
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = "Epic space adventure"
                }
            );
        }
    }
}