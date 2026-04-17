using Microsoft.EntityFrameworkCore;

namespace AktauVoiceApi.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Report> Reports { get; set; }
}