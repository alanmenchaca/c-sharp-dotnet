namespace design_patterns.Creational.Builder.Article.Solution;

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

    public static Builder Make(long id)
    {
        return new Builder(id);
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

    public class Builder
    {
        private readonly Article _article;

        public Builder(long id)
        {
            _article = new Article(id);
        }
        
        public Builder Phone(long phone)
        {
            _article.AddPhone(phone);
            return this;
        }

        public Builder Reference(string? reference)
        {
            _article.Reference = reference;
            return this;
        }

        public Builder Description(string? description)
        {
            _article.Description = description;
            return this;
        }

        public Builder RetailPrice(decimal retailPrice)
        {
            _article.RetailPrice = retailPrice;
            return this;
        }

        public Builder Stock(int stock)
        {
            _article.Stock = stock;
            return this;
        }

        public Builder WholeSalePrice(decimal wholeSalePrice)
        {
            _article.WholeSalePrice = wholeSalePrice;
            return this;
        }

        public Builder Tag(string tag)
        {
            if (_article.Tags == null)
                _article.Tags = new List<string>();

            _article.Tags.Add(tag);
            return this;
        }

        public Article Build()
        {
            return _article;
        }
    }
}