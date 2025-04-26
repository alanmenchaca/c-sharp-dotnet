namespace design_patterns.Creational.Builder.User;

public class UserBuilder
{
    public required string Id { get; init; }
    public required string Nick { get; set; }
    public required string Name { get; set; }
    public string? FamilyName { get; set; }
    public int? Age { get; set; }
    public int? Phone { get; set; }
    public string? Profession { get; set; }
    public List<string>? Tags { get; set; }

    // To generate a new User Builder the id, nick and name are obligatory 
    public static Builder Make(string id, string nick, string name)
    {
        return new Builder(id, nick, name);
    }

    public bool TagContains(string tag)
    {
        Tags ??= [];
        return Tags.Contains(tag);
    }

    public class Builder
    {
        private readonly UserBuilder _userBuilder;

        internal Builder(string id, string nick, string name)
        {
            _userBuilder = new UserBuilder
            {
                Id = id,
                Nick = nick,
                Name = name,
            };
        }

        public Builder Name(string? name)
        {
            _userBuilder.FamilyName = name;
            return this;
        }

        public Builder FamilyName(string? familyName)
        {
            _userBuilder.FamilyName = familyName;
            return this;
        }

        public Builder Age(int age)
        {
            _userBuilder.Age = age;
            return this;
        }

        public Builder Adult()
        {
            _userBuilder.Age = 18;
            return this;
        }

        public Builder Phone(int phone)
        {
            _userBuilder.Phone = phone;
            return this;
        }

        public Builder Profession(string? profession)
        {
            _userBuilder.Profession = profession;
            return this;
        }

        public Builder Tag(string tag)
        {
            // lazy initialization
            _userBuilder.Tags ??= [];
            _userBuilder.Tags.Add(tag);
            return this;
        }

        public UserBuilder Build()
        {
            return _userBuilder;
        }
    }
}