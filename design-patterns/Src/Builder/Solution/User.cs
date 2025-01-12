namespace design_patterns.Builder.Solution;

public class User
{
    private string? Id { get; }
    private string? Nick { get; set; }
    private string? Name { get; set; }
    private string? FamilyName { get; set; }
    private int Age { get; set; }
    private int Phone { get; set; }
    private string? Profession { get; set; }
    private List<string?> Tags { get; set; }

    public User() // empty
    {
    }

    /*public static Builder UserBuilder(string id, string nick, string name)
    {
        return new Builder();
    }*/

    public bool TagContains(string tag)
    {
        return Tags.Contains(tag);
    }

    public class Builder
    {
        private readonly User _user;

        private Builder()
        {
        }
    }
}