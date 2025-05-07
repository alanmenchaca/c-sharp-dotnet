using design_patterns.Creational.Builder.Article;
using NUnit.Framework;

namespace design_patterns.Test.Creational.Builder.Article;

public class ArticleTest
{
    [Test]
    public void BuildEmptyArticle_ShouldReturnArticleWithDefaultValues()
    {
        // Arrange
        var articleBuilder = ArticleBuilder.Make(1);

        // Act
        var article = articleBuilder.Build();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(article, Is.Not.Null);
            Assert.That(article.Id, Is.EqualTo(1));
            Assert.That(article.Phones, Is.Null);
            Assert.That(article.Reference, Is.Null);
            Assert.That(article.Description, Is.Null);
            Assert.That(article.RetailPrice, Is.EqualTo(0));
            Assert.That(article.Stock, Is.EqualTo(0));
            Assert.That(article.WholeSalePrice, Is.EqualTo(0));
            Assert.That(article.Tags, Is.Null);
        });
    }

    [Test]
    public void BuildArticleWithPartialFields_ShouldReturnArticleWithSetFields()
    {
        // Arrange
        var articleBuilder = ArticleBuilder
            .Make(1)
            .Phone(123456789)
            .Reference("123456")
            .Description("Article description")
            .RetailPrice(100);

        // Act
        var article = articleBuilder.Build();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(article.Id, Is.EqualTo(1));
            Assert.That(article.Phones, Is.EquivalentTo([123456789]));
            Assert.That(article.Reference, Is.EqualTo("123456"));
            Assert.That(article.Description, Is.EqualTo("Article description"));
            Assert.That(article.RetailPrice, Is.EqualTo(100));
            Assert.That(article.Stock, Is.EqualTo(0));
            Assert.That(article.WholeSalePrice, Is.EqualTo(0));
            Assert.That(article.Tags, Is.Null);
        });
    }

    [Test]
    public void BuildFullArticle_ShouldReturnArticleWithAllFieldsSet()
    {
        // Arrange
        var articleBuilder = ArticleBuilder
            .Make(1)
            .Phone(123456789)
            .Phone(987654321)
            .Reference("123456")
            .Description("Article description")
            .RetailPrice(100)
            .Stock(10)
            .WholeSalePrice(90)
            .Tag("tag1")
            .Tag("tag2");

        // Act
        var article = articleBuilder.Build();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(article.Id, Is.EqualTo(1));
            Assert.That(article.Phones, Is.EquivalentTo([123456789, 987654321]));
            Assert.That(article.Reference, Is.EqualTo("123456"));
            Assert.That(article.Description, Is.EqualTo("Article description"));
            Assert.That(article.RetailPrice, Is.EqualTo(100));
            Assert.That(article.Stock, Is.EqualTo(10));
            Assert.That(article.WholeSalePrice, Is.EqualTo(90));
            Assert.That(article.Tags, Is.EquivalentTo(["tag1", "tag2"]));
        });
    }
}