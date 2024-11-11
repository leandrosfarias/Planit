using System.ComponentModel.DataAnnotations;

namespace Planit.Domain.Entities;

public class Project
{
    public int Id { get; set; }
    [Required]
    [StringLength(20)]
    public required string Name { get; set; }
    [StringLength(50)]
    public string? Description { get; set; }
    [Required]
    public DateTime CreatedDate { get; set; }
    [Required]
    public DateTime UpdatedDate { get; set; }
    public List<TaskItem> TaskItems { get; set; } = [];
}

