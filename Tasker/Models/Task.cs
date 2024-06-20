namespace Tasker.Models;

public class Task
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Text { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? ChangedAt { get; set; }
    public bool IsCompleted { get; set; }
    public bool IsDeleted { get; set; }
}