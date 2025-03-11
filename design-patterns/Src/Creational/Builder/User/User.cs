namespace design_patterns.Creational.Builder.User;

public class User
{
    public string? Id { get; }
    public string? Nick { get; set; }
    public string? Name { get; set; }
    public string? FamilyName { get; set; }
    public int Age { get; set; }
    public int Phone { get; set; }
    public string Profession { get; set; }
    public List<string> Tags { get; set; }

    public User(string? id, string? nick)
    {
        Id = id;
        Nick = nick;
    }

    public User(string? id, string? nick, string? name, string? familyName,
        int age, int phone, string profession, List<string> tags) : this(id, nick)

    {
        Name = name;
        FamilyName = familyName;
        Age = age;
        Phone = phone;
        Profession = profession;
        Tags = tags;
    }

    public User(string? id, string? nick, string? name) : this(id, nick)
    {
        Name = name;
    }

    public User(string? id, string? nick, string? name, string? familyName, int phone)
        : this(id, nick, name, familyName, 0, phone, null!, null!)
    {
    }

    public override string ToString()
    {
        return "User{" +
               $"Id='{Id}', " +
               $"Nick='{Nick}', " +
               $"Name='{Name}', " +
               $"FamilyName='{FamilyName}', " +
               $"Age={Age}, " +
               $"Phone={Phone}, " +
               $"Profession='{Profession}', " +
               $"Tags={string.Join(",", Tags)}" +
               "}";
    }
}