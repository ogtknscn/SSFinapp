using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SSFinapp.Data;

/// <summary>
/// Design-time DbContext factory for EF Core migrations
/// </summary>
public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        
        // Default SQLite connection string for migrations
        optionsBuilder.UseSqlite("Data Source=ssfinapp.db");
        
        return new ApplicationDbContext(optionsBuilder.Options);
    }
}

