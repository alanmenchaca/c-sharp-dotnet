using design_patterns.Creational.Builder.User;
using NUnit.Framework;

namespace design_patterns.Test.Creational.Builder.User;

public class UserBuilderTest
{
    [Test]
    public void TestUserFull()
    {
        var user = UserBuilder
            .Make("1", "Paco", "Jose")
            .FamilyName("De Miguel")
            .Phone(666666666)
            .Adult()
            .Profession("Profesor")
            .Tag("Director").Tag("Socio").Tag("Consejo")
            .Build();

        Assert.That(user.Id, Is.EqualTo("1"));
        Assert.That(user.Nick, Is.EqualTo("Paco"));
        Assert.That(user.Name, Is.EqualTo("Jose"));
        Assert.That(user.FamilyName, Is.EqualTo("De Miguel"));
        Assert.That(user.Age, Is.EqualTo(18));
        Assert.That(user.Phone, Is.EqualTo(666666666));
        Assert.That(user.Profession, Is.EqualTo("Profesor"));
        Assert.That(user.Tags?.Count, Is.EqualTo(3));
    }

    [Test]
    public void TestUserPartial()
    {
        var user = UserBuilder
            .Make("1", "Paco", "Jose")
            .Phone(666666666)
            .FamilyName("De Miguel")
            .Build();

        Assert.That(user.Id, Is.EqualTo("1"));
        Assert.That(user.Nick, Is.EqualTo("Paco"));
        Assert.That(user.Name, Is.EqualTo("Jose"));
        Assert.That(user.FamilyName, Is.EqualTo("De Miguel"));
        Assert.That(user.Phone, Is.EqualTo(666666666));
    }
}