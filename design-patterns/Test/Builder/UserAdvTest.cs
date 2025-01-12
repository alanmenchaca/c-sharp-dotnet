using design_patterns.Builder.User.AdvancedSolution;

namespace design_patterns.Test.Builder;

public class UserAdvTest
{
    [Fact]
    public void TestUserFull()
    {
        User user = User.Make()
            .Id("1")
            .Nick("Paco")
            .Name("Jose")
            .FamilyName("De Miguel")
            .Phone(666666666)
            .Age(18)
            .Profession("Profesor")
            .Tag("Director")
            .Tag("socio")
            .Tag("Consejo")
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
        User user = User.Make()
            .Id("1")
            .Nick("Paco")
            .Name("Jose")
            .Tag("Director")
            .Age(18)
            .Build();
        
        Assert.Equal("1", user.Id);
        Assert.Equal("Paco", user.Nick);
        Assert.Equal("Jose", user.Name);
        Assert.Equal(18, user.Age);
        Assert.Single(user.Tags);
    }
}