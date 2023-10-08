using EFExample.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace EFExample;

public class AppDbContext : DbContext
{
    static string CSHome = "Host=localhost;Username=postgres;Password=admin;Database=Learn_MaximaSchool";
    static string CSWork = "Host=localhost;Username=postgres;Password=admin;Database=postgres";
    private static readonly string ConnectionString = CSHome;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(ConnectionString);
        
#if DEBUG
        optionsBuilder.EnableSensitiveDataLogging();
#endif
        
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
    }

    public DbSet<User> Users { get; set; }
}