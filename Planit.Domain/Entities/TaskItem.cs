using System.ComponentModel.DataAnnotations;

namespace Planit.Domain.Entities;

public class TaskItem
{
    public int Id { get; set; }
    [Required]
    [StringLength(20)]
    public required string Name { get; set; }
    [Required]
    public string? Description { get; set; }
    [Required]
    public StatusTaskItem Status { get; set; } = StatusTaskItem.toDo;
    [Required]
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public DateTime CompletionDate { get; set; }
    public List<TaskItem> SubTaskItem { get; set; } = [];
}
