using design_patterns.Builder.User.Solution;

namespace design_patterns.Test.Builder;

public class UserTest
{
    [Fact]
    public void TestUserFull()
    {
        User user = User.Make("1", "Paco", "Jose")
            .FamilyName("De Miguel")
            .Phone(666666666)
            .Adult()
            .Profession("Profesor")
            .Tag("Director").Tag("Socio").Tag("Consejo")
            .Build();

        Assert.Equal("1", user.Id);
        Assert.Equal("Paco", user.Nick);
        Assert.Equal("Jose", user.Name);
        Assert.Equal("De Miguel", user.FamilyName);
        Assert.Equal(18, user.Age);
        Assert.Equal(666666666, user.Phone);
        Assert.Equal("Profesor", user.Profession);
        Assert.Equal(3, user.Tags.Count);
    }

    [Fact]
    public void TestUserPartial()
    {
        User user = User.Make("1", "Paco", "Jose")
            .Phone(666666666)
            .FamilyName("De Miguel")
            .Build();

        Assert.Equal("1", user.Id);
        Assert.Equal("Paco", user.Nick);
        Assert.Equal("Jose", user.Name);
        Assert.Equal("De Miguel", user.FamilyName);
        Assert.Equal(666666666, user.Phone);
    }
}