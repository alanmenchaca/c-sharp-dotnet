namespace design_patterns.Creational.Builder.Article;

public class Provider
{
    public required string Id { get; set; }
    public required string Company { get; set; }
    public required string Description { get; set; }
    public required string Nif { get; set; }
    public required string Address { get; set; }
    public required string Phone { get; set; }
    public required string Email { get; set; }
    public required string Note { get; set; }

    public override string ToString()
    {
        return $"Article [Id= {Id}, " +
               $"Company= " +
               $"{Company}, " +
               $"Description= " +
               $"{Description}, " +
               $"Nif= {Nif}, " +
               $"Address= {Address}, " +
               $"Phone= {Phone}, " +
               $"Email= {Email}, " +
               $"Note= {Note}]";
    }
}