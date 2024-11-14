using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        // 如果資料庫不存在，會建立資料庫
        Database.EnsureCreated();
    }
}