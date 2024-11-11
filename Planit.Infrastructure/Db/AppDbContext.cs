using Microsoft.EntityFrameworkCore;
using Planit.Domain.Entities;

namespace Planit.Infrastructure.Db;

public class AppDbContext : DbContext
{
    public DbSet<User> users;
    public DbSet<Project> projects;
    public DbSet<TaskItem> tasks;

    public AppDbContext(DbContextOptionsBuilder<AppDbContext> options) : base()
    {
        options.UseSqlServer();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
