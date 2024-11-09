using System.ComponentModel.DataAnnotations;

namespace Planit.Domain;

public class User
{
    public int Id { get; set; }
    [Required]
    [StringLength(10)]
    public required string Name { get; set; }
    [Required]
    public required string Email { get; set; }
    [Required]
    public required string Password { get; set; }
    [Required]
    public required string UserName { get; set; }
}
