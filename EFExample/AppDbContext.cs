using EFExample.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFExample;

public class AppDbContext : DbContext
{
    static string CSHome = "Host=localhost;Username=postgres;Password=admin;Database=Learn_MaximaSchool";
    static string CSWork = "Host=localhost;Username=postgres;Password=admin;Database=postgres";
    private static readonly string ConnectionString = CSWork;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(ConnectionString);
    }

    public DbSet<User> Users { get; set; }
}