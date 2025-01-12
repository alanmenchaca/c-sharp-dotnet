namespace design_patterns.Builder.User.AdvancedSolution;

public class User
{
    public string? Id { get; set; }
    public string? Nick { get; set; }
    public string? Name { get; set; }
    public string? FamilyName { get; set; }
    public int Age { get; set; }
    public int Phone { get; set; }
    public string? Profession { get; set; }
    public List<string> Tags { get; set; }

    public User()
    {
    }
    
    public static Builder Make()
    {
        return new Builder();
    }

    public bool TagContains(string tag)
    {
        return Tags.Contains(tag);
    }

    public class Builder : IUserBuilders.ID, IUserBuilders.INick, IUserBuilders.IName, IUserBuilders.IOptionals
    {
        private readonly User _user;

        public Builder()
        {
            _user = new User();
        }

        public IUserBuilders.INick Id(string id)
        {
            _user.Id = id;
            return this;
        }

        public IUserBuilders.IName Nick(string nick)
        {
            _user.Nick = nick;
            return this;
        }

        public IUserBuilders.IOptionals Name(string name)
        {
            _user.Name = name;
            return this;
        }

        public IUserBuilders.IOptionals FamilyName(string familyName)
        {
            _user.FamilyName = familyName;
            return this;
        }

        public IUserBuilders.IOptionals Age(int age)
        {
            _user.Age = age;
            return this;
        }

        public IUserBuilders.IOptionals Phone(int phone)
        {
            _user.Phone = phone;
            return this;
        }

        public IUserBuilders.IOptionals Profession(string profession)
        {
            _user.Profession = profession;
            return this;
        }

        public IUserBuilders.IOptionals Tag(string tag)
        {
            if (_user.Tags == null)
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