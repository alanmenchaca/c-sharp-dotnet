using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_ef.models;

public class Tasks
{
    [Key] public Guid TaskId { get; set; }
    [Required] [MaxLength(200)] public string? Title { get; set; }
    public string Description { get; set; }
    [NotMapped] public string? Summary { get; set; }
    public Priority Priority { get; set; }
    public DateTime CreatedAt { get; set; }

    [ForeignKey("CategoryId")] public Guid CategoryId { get; set; }
    public virtual Category Category { get; set; }
}

public enum Priority
{
    Low,
    Medium,
    High
}