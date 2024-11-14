using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        WeatherForecasts = Set<WeatherForecast>();
    }

    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
}