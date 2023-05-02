using Microsoft.EntityFrameworkCore;

namespace Api.Models;

public class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
        
    }
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public DbSet<Project> Projects { get; set; } = null!;
}