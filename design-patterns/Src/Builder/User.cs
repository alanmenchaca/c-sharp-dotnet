namespace design_patterns.Builder;

public class User
{
    private string? Id { get; }
    private string? Nick { get; set; }
    private string? Name { get; set; }
    private string? FamilyName { get; set; }
    private int Age { get; set; }
    private int Phone { get; set; }
    private string Profession { get; set; }
    private List<string> Tags { get; set; }

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
        : this(id, nick, name, familyName, 0, phone, null!, null!) { }

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