using EFExample.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFExample;

public class AppDbContext : DbContext
{
    private const string ConnectionString = "Host=localhost;Username=postgres;Password=admin;Database=Learn_MaximaSchool";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(ConnectionString);
    }

    public DbSet<User> Users { get; set; }
}