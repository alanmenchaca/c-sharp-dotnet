using design_patterns.Builder.User.AdvancedSolution;
using NUnit.Framework;

namespace design_patterns.Test.Builder;

public class UserAdvTest
{
    [Test]
    public void TestUserFull()
    {
        var user = User.Make()
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
        
        Assert.That(user.Id, Is.EqualTo("1"));
        Assert.That(user.Nick, Is.EqualTo("Paco"));
        Assert.That(user.Name, Is.EqualTo("Jose"));
        Assert.That(user.FamilyName, Is.EqualTo("De Miguel"));
        Assert.That(user.Age, Is.EqualTo(18));
        Assert.That(user.Phone, Is.EqualTo(666666666));
        Assert.That(user.Profession, Is.EqualTo("Profesor"));
        Assert.That(user.Tags.Count, Is.EqualTo(3));
    }

    [Test]
    public void TestUserPartial()
    {
        var user = User.Make()
            .Id("1")
            .Nick("Paco")
            .Name("Jose")
            .Tag("Director")
            .Age(18)
            .Build();

        Assert.That(user.Id, Is.EqualTo("1"));
        Assert.That(user.Nick, Is.EqualTo("Paco"));
        Assert.That(user.Name, Is.EqualTo("Jose"));
        Assert.That(user.Age, Is.EqualTo(18));
        Assert.That(user.Tags.Count, Is.EqualTo(1));
    }
}