using design_patterns.Creational.Builder.Article;
using NUnit.Framework;

namespace design_patterns.Test.Creational.Builder.Article;

public class ProviderTest
{
    [Test]
    public void FullProviderTest()
    {
        var provider = ProviderBuilder
            .Make()
            .Id("1")
            .Company("Company")
            .Description("Provider description")
            .Nif("123456789")
            .Address("Address")
            .Phone("987654321")
            .Email("JohnDoe@gmail.com")
            .Note("Note")
            .Build();

        Assert.That(provider.Id, Is.EqualTo("1"));
        Assert.That(provider.Company, Is.EqualTo("Company"));
        Assert.That(provider.Description, Is.EqualTo("Provider description"));
        Assert.That(provider.Nif, Is.EqualTo("123456789"));
        Assert.That(provider.Address, Is.EqualTo("Address"));
        Assert.That(provider.Phone, Is.EqualTo("987654321"));
        Assert.That(provider.Email, Is.EqualTo("JohnDoe@gmail.com"));
        Assert.That(provider.Note, Is.EqualTo("Note"));
    }

    [Test]
    public void PartialProviderTest()
    {
        var provider = ProviderBuilder
            .Make()
            .Id("1")
            .Company("Company")
            .Build();

        Assert.That(provider.Id, Is.EqualTo("1"));
        Assert.That(provider.Company, Is.EqualTo("Company"));
        Assert.That(provider.Description, Is.Null);
        Assert.That(provider.Nif, Is.Null);
        Assert.That(provider.Address, Is.Null);
        Assert.That(provider.Phone, Is.Null);
        Assert.That(provider.Email, Is.Null);
        Assert.That(provider.Note, Is.Null);
    }
}