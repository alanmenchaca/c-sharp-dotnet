using design_patterns.Creational.Builder.Client;
using NUnit.Framework;

namespace design_patterns.Test.Creational.Builder.Client;

public class ClientBuilderTest
{
    [Test]
    public void TestClientFull()
    {
        var client = ClientBuilder
            .Make()
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

        Assert.That(client.Id, Is.EqualTo("1"));
        Assert.That(client.Nick, Is.EqualTo("Paco"));
        Assert.That(client.Name, Is.EqualTo("Jose"));
        Assert.That(client.FamilyName, Is.EqualTo("De Miguel"));
        Assert.That(client.Phone, Is.EqualTo(666666666));
        Assert.That(client.Age, Is.EqualTo(18));
        Assert.That(client.Profession, Is.EqualTo("Profesor"));
        Assert.That(client.Tags?.Count, Is.EqualTo(3));
    }

    [Test]
    public void TestClientPartial()
    {
        var client = ClientBuilder
            .Make()
            .Id("1")
            .Nick("Paco")
            .Name("Jose")
            .Tag("Director")
            .Age(18)
            .Build();

        Assert.That(client.Id, Is.EqualTo("1"));
        Assert.That(client.Nick, Is.EqualTo("Paco"));
        Assert.That(client.Name, Is.EqualTo("Jose"));
        Assert.That(client.Age, Is.EqualTo(18));
        Assert.That(client.Tags?.Count, Is.EqualTo(1));
    }
}