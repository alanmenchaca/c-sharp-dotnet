namespace design_patterns.Creational.Builder.Article;

public class Article
{
    public long Id { get; }
    public List<long> Phones { get; } = [];
    public string? Reference { get; set; }
    public string? Description { get; set; }
    public decimal RetailPrice { get; set; }
    public int Stock { get; set; }
    public decimal WholeSalePrice { get; set; }
    public List<string>? Tags { get; set; }

    public Article(long id)
    {
        Id = id;
    }

    public void AddPhone(long phone)
    {
        Phones.Add(phone);
    }

    public override string ToString()
    {
        return $"Article [Id= {Id}, " +
               $"Phones= {string.Join(", ", Phones)}, " +
               $"Reference= {Reference}, " +
               $"Description= {Description}, " +
               $"RetailPrice= {RetailPrice}, " +
               $"Stock= {Stock}, " +
               $"WholeSalePrice= {WholeSalePrice}, " +
               $"Tags= {string.Join(", ", Tags)}]";
    }
}