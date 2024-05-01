using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Npgsql;

public class BooksDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var dbBuilder = new NpgsqlDataSourceBuilder(@"Host=localhost:5432;Username=postgres;Password=postgres;Database=booksdb");
        dbBuilder.EnableDynamicJson();

        optionsBuilder
            .UseNpgsql(dbBuilder.Build())
            .UseSnakeCaseNamingConvention()
			.LogTo(Console.WriteLine, LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Book>()
            .Property(b => b.BookDetails)
            .HasColumnType("jsonb");
    }
}