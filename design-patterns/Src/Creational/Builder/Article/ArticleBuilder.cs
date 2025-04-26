namespace design_patterns.Creational.Builder.Article;

public class ArticleBuilder
{
    public long Id { get; set; }
    public List<long>? Phones { get; set; }
    public string? Reference { get; set; }
    public string? Description { get; set; }
    public decimal RetailPrice { get; set; }
    public int Stock { get; set; }
    public decimal WholeSalePrice { get; set; }
    public List<string>? Tags { get; set; }

    public ArticleBuilder(long id)
    {
        Id = id;
    }

    public void AddPhone(long phone)
    {
        Phones ??= [];
        Phones.Add(phone);
    }

    public static Builder Make(long id)
    {
        return new Builder(id);
    }

    public override string ToString()
    {
        return $"Article [Id= {Id}, " +
               $"Phones= {string.Join(", ", Phones ??= [])}, " +
               $"Reference= {Reference}, " +
               $"Description= {Description}, " +
               $"RetailPrice= {RetailPrice}, " +
               $"Stock= {Stock}, " +
               $"WholeSalePrice= {WholeSalePrice}, " +
               $"Tags= {string.Join(", ", Tags ??= [])}]";
    }

    public class Builder
    {
        private readonly ArticleBuilder _articleBuilder;

        public Builder(long id)
        {
            _articleBuilder = new ArticleBuilder(id);
        }

        public Builder Phone(long phone)
        {
            _articleBuilder.AddPhone(phone);
            return this;
        }

        public Builder Reference(string reference)
        {
            _articleBuilder.Reference = reference;
            return this;
        }

        public Builder Description(string description)
        {
            _articleBuilder.Description = description;
            return this;
        }

        public Builder RetailPrice(decimal retailPrice)
        {
            _articleBuilder.RetailPrice = retailPrice;
            return this;
        }

        public Builder Stock(int stock)
        {
            _articleBuilder.Stock = stock;
            return this;
        }

        public Builder WholeSalePrice(decimal wholeSalePrice)
        {
            _articleBuilder.WholeSalePrice = wholeSalePrice;
            return this;
        }

        public Builder Tag(string tag)
        {
            _articleBuilder.Tags ??= [];
            _articleBuilder.Tags.Add(tag);
            return this;
        }

        public ArticleBuilder Build()
        {
            return _articleBuilder;
        }
    }
}