using System.ComponentModel.DataAnnotations;

namespace Planit.Domain.Entities;

public class User
{
    public int Id { get; set; }
    [Required]
    [StringLength(20)]
    public required string Name { get; set; }
    [Required]
    [StringLength(20)]
    public required string Email { get; set; }
    [Required]
    public required string Password { get; set; }
    [Required]
    [StringLength(10)]
    public required string UserName { get; set; }
    public List<Project> Projects { get; set; } = [];
}
