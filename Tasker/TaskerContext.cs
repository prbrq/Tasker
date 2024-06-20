using Microsoft.EntityFrameworkCore;

namespace Tasker;

public class TaskerContext : DbContext
{
    public DbSet<Models.Task> Tasks { get; set; }

    public TaskerContext(DbContextOptions<TaskerContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}