namespace design_patterns.Creational.Builder.Article.Solution;

public class Provider
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
        private readonly Provider _provider;

        public Builder()
        {
            _provider = new Provider();
        }

        public Builder Id(string id)
        {
            _provider.Id = id;
            return this;
        }

        public Builder Company(string company)
        {
            _provider.Company = company;
            return this;
        }

        public Builder Description(string description)
        {
            _provider.Description = description;
            return this;
        }

        public Builder Nif(string nif)
        {
            _provider.Nif = nif;
            return this;
        }

        public Builder Address(string address)
        {
            _provider.Address = address;
            return this;
        }

        public Builder Phone(string phone)
        {
            _provider.Phone = phone;
            return this;
        }

        public Builder Email(string email)
        {
            _provider.Email = email;
            return this;
        }

        public Builder Note(string note)
        {
            _provider.Note = note;
            return this;
        }

        public Provider Build()
        {
            return _provider;
        }
    }
}