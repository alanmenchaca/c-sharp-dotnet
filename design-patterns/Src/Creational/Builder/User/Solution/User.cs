namespace design_patterns.Creational.Builder.User.Solution;

public class User
{
    public string? Id { get; private set; }
    public string? Nick { get; set; }
    public string? Name { get; set; }
    public string? FamilyName { get; set; }
    public int Age { get; set; }
    public int Phone { get; set; }
    public string? Profession { get; set; }
    public List<string?> Tags { get; set; }

    public User() // empty
    {
    }

    // To generate a new User Builder the id, nick and name are obligatory 
    public static Builder Make(string id, string nick, string name)
    {
        return new Builder(id, nick, name);
    }

    public bool TagContains(string tag)
    {
        return Tags.Contains(tag);
    }

    public class Builder
    {
        private readonly User _user;

        internal Builder(string id, string nick, string name)
        {
            _user = new User()
            {
                Id = id,
                Nick = nick,
                Name = name,
            };
        }

        public Builder Name(string name)
        {
            _user.FamilyName = name;
            return this;
        }

        public Builder FamilyName(string familyName)
        {
            _user.FamilyName = familyName;
            return this;
        }

        public Builder Age(int age)
        {
            _user.Age = age;
            return this;
        }

        public Builder Adult()
        {
            _user.Age = 18;
            return this;
        }

        public Builder Phone(int phone)
        {
            _user.Phone = phone;
            return this;
        }

        public Builder Profession(string profession)
        {
            _user.Profession = profession;
            return this;
        }

        public Builder Tag(string? tag)
        {
            // lazy initialization
            if (_user.Tags is null)
                _user.Tags = [];

            _user.Tags.Add(tag);
            return this;
        }

        public User Build()
        {
            return _user;
        }
    }
}