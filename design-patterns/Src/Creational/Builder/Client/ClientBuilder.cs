namespace design_patterns.Creational.Builder.Client;

public class ClientBuilder
{
    public string? Id { get; private set; }
    public string? Nick { get; private set; }
    public string? Name { get; private set; }
    public string? FamilyName { get; private set; }
    public int Age { get; private set; }
    public int Phone { get; private set; }
    public string? Profession { get; private set; }
    public List<string>? Tags { get; private set; }

    public static Builder Make()
    {
        return new Builder();
    }

    public bool TagContains(string tag)
    {
        Tags ??= [];
        return Tags.Contains(tag);
    }

    public class Builder : IClientBuilders.ID, IClientBuilders.INick, IClientBuilders.IName, IClientBuilders.IOptionals
    {
        private readonly ClientBuilder _clientBuilder;

        public Builder()
        {
            _clientBuilder = new ClientBuilder();
        }

        public IClientBuilders.INick Id(string id)
        {
            _clientBuilder.Id = id;
            return this;
        }

        public IClientBuilders.IName Nick(string nick)
        {
            _clientBuilder.Nick = nick;
            return this;
        }

        public IClientBuilders.IOptionals Name(string name)
        {
            _clientBuilder.Name = name;
            return this;
        }

        public IClientBuilders.IOptionals FamilyName(string familyName)
        {
            _clientBuilder.FamilyName = familyName;
            return this;
        }

        public IClientBuilders.IOptionals Age(int age)
        {
            _clientBuilder.Age = age;
            return this;
        }

        public IClientBuilders.IOptionals Phone(int phone)
        {
            _clientBuilder.Phone = phone;
            return this;
        }

        public IClientBuilders.IOptionals Profession(string profession)
        {
            _clientBuilder.Profession = profession;
            return this;
        }

        public IClientBuilders.IOptionals Tag(string tag)
        {
            _clientBuilder.Tags ??= [];
            _clientBuilder.Tags.Add(tag);
            return this;
        }

        public ClientBuilder Build()
        {
            return _clientBuilder;
        }
    }
}