using design_patterns.Creational.Builder.Article;
using NUnit.Framework;

namespace design_patterns.Test.Creational.Builder.Article;

public class ProviderTest
{
    [Test]
    public void BuildEmptyProvider_ShouldReturnProviderWithDefaultValues()
    {
        // Arrange
        var providerBuilder = ProviderBuilder.Make();

        // Act
        var provider = providerBuilder.Build();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(provider, Is.Not.Null);
            Assert.That(provider.Id, Is.Null);
            Assert.That(provider.Company, Is.Null);
            Assert.That(provider.Description, Is.Null);
            Assert.That(provider.Nif, Is.Null);
            Assert.That(provider.Address, Is.Null);
            Assert.That(provider.Phone, Is.Null);
            Assert.That(provider.Email, Is.Null);
            Assert.That(provider.Note, Is.Null);
        });
    }

    [Test]
    public void BuildProviderWithPartialFields_ShouldReturnProviderWithSetFields()
    {
        // Arrange
        var providerBuilder = ProviderBuilder
            .Make()
            .Id("1")
            .Company("Company");

        // Act
        var provider = providerBuilder.Build();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(provider.Id, Is.EqualTo("1"));
            Assert.That(provider.Company, Is.EqualTo("Company"));
            Assert.That(provider.Description, Is.Null);
            Assert.That(provider.Nif, Is.Null);
            Assert.That(provider.Address, Is.Null);
            Assert.That(provider.Phone, Is.Null);
            Assert.That(provider.Email, Is.Null);
            Assert.That(provider.Note, Is.Null);
        });
    }

    [Test]
    public void BuildProviderWithAllFields_ShouldReturnFullProvider()
    {
        // Arrange
        var providerBuilder = ProviderBuilder
            .Make()
            .Id("1")
            .Company("Company")
            .Description("Provider description")
            .Nif("123456789")
            .Address("Address")
            .Phone("987654321")
            .Email("JohnDoe@gmail.com")
            .Note("Note");

        // Act
        var provider = providerBuilder.Build();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(provider.Id, Is.EqualTo("1"));
            Assert.That(provider.Company, Is.EqualTo("Company"));
            Assert.That(provider.Description, Is.EqualTo("Provider description"));
            Assert.That(provider.Nif, Is.EqualTo("123456789"));
            Assert.That(provider.Address, Is.EqualTo("Address"));
            Assert.That(provider.Phone, Is.EqualTo("987654321"));
            Assert.That(provider.Email, Is.EqualTo("JohnDoe@gmail.com"));
            Assert.That(provider.Note, Is.EqualTo("Note"));
        });
    }
}