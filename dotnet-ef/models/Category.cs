using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace dotnet_ef.models;

public class Category
{
    [Key] public Guid CategoryId { get; set; }
    [Required] [MaxLength(150)] public string? CategoryName { get; set; }
    public string? Description { get; set; }
    public int Weight { get; set; }

    [JsonIgnore]
    public virtual ICollection<Tasks> Tasks { get; set; }
}