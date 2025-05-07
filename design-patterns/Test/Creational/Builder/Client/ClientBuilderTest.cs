using design_patterns.Creational.Builder.Client;
using NUnit.Framework;

namespace design_patterns.Test.Creational.Builder.Client;

public class ClientBuilderTest
{
    [Test]
    public void BuildEmptyClient_ShouldReturnClientWithDefaultValues()
    {
        // Arrange
        var clientBuilder = ClientBuilder.Make();

        // Act
        var client = clientBuilder.Build();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(client, Is.Not.Null);
            Assert.That(client.Id, Is.Null);
            Assert.That(client.Nick, Is.Null);
            Assert.That(client.Name, Is.Null);
            Assert.That(client.FamilyName, Is.Null);
            Assert.That(client.Phone, Is.Zero);
            Assert.That(client.Age, Is.Zero);
            Assert.That(client.Profession, Is.Null);
            Assert.That(client.Tags?.Count, Is.Null);
        });
    }

    [Test]
    public void BuildClientWithPartialFields_ShouldReturnClientWithSetFields()
    {
        // Arrange
        var clientBuilder = ClientBuilder
            .Make()
            .Id("1")
            .Nick("John")
            .Name("Doe")
            .Tag("Director")
            .Age(18);

        // Act
        var client = clientBuilder.Build();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(client.Id, Is.EqualTo("1"));
            Assert.That(client.Nick, Is.EqualTo("John"));
            Assert.That(client.Name, Is.EqualTo("Doe"));
            Assert.That(client.Age, Is.EqualTo(18));
            Assert.That(client.Tags?.Count, Is.EqualTo(1));
        });
    }

    [Test]
    public void BuildClientWithAllFields_ShouldReturnFullClient()
    {
        // Arrange
        var clientBuilder = ClientBuilder
            .Make()
            .Id("1")
            .Nick("John")
            .Name("Doe")
            .FamilyName("Doe")
            .Phone(666666666)
            .Age(18)
            .Profession("Profesor")
            .Tag("Director")
            .Tag("socio")
            .Tag("Consejo");

        // Act
        var client = clientBuilder.Build();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(client.Id, Is.EqualTo("1"));
            Assert.That(client.Nick, Is.EqualTo("John"));
            Assert.That(client.Name, Is.EqualTo("Doe"));
            Assert.That(client.FamilyName, Is.EqualTo("Doe"));
            Assert.That(client.Phone, Is.EqualTo(666666666));
            Assert.That(client.Age, Is.EqualTo(18));
            Assert.That(client.Profession, Is.EqualTo("Profesor"));
            Assert.That(client.Tags?.Count, Is.EqualTo(3));
        });
    }
}