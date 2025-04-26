namespace design_patterns.Creational.Builder.Article;

public class ProviderBuilder
{
    public string? Id { get; set; }
    public string? Company { get; set; }
    public string? Description { get; set; }
    public string? Nif { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Note { get; set; }

    public static Builder Make()
    {
        return new Builder();
    }

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

    public class Builder
    {
        private readonly ProviderBuilder _providerBuilder;

        public Builder()
        {
            _providerBuilder = new ProviderBuilder();
        }

        public Builder Id(string id)
        {
            _providerBuilder.Id = id;
            return this;
        }

        public Builder Company(string company)
        {
            _providerBuilder.Company = company;
            return this;
        }

        public Builder Description(string description)
        {
            _providerBuilder.Description = description;
            return this;
        }

        public Builder Nif(string nif)
        {
            _providerBuilder.Nif = nif;
            return this;
        }

        public Builder Address(string address)
        {
            _providerBuilder.Address = address;
            return this;
        }

        public Builder Phone(string phone)
        {
            _providerBuilder.Phone = phone;
            return this;
        }

        public Builder Email(string email)
        {
            _providerBuilder.Email = email;
            return this;
        }

        public Builder Note(string note)
        {
            _providerBuilder.Note = note;
            return this;
        }

        public ProviderBuilder Build()
        {
            return _providerBuilder;
        }
    }
}