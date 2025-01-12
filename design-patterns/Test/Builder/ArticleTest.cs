using design_patterns.Builder.Article.Solution;

namespace design_patterns.Test.Builder;

public class ArticleTest
{
    [Fact]
    public void FullArticleTest()
    {
        Article article = Article.Make(1)
            .Phone(123456789)
            .Phone(987654321)
            .Reference("123456")
            .Description("Article description")
            .RetailPrice(100)
            .Stock(10)
            .WholeSalePrice(90)
            .Tag("tag1")
            .Tag("tag2")
            .Build();

        Assert.Equal(1, article.Id);
        Assert.Equal([123456789, 987654321], article.Phones);
        Assert.Equal("123456", article.Reference);
        Assert.Equal("Article description", article.Description);
        Assert.Equal(100, article.RetailPrice);
        Assert.Equal(10, article.Stock);
        Assert.Equal(90, article.WholeSalePrice);
        Assert.Equal(["tag1", "tag2"], article.Tags);
    }
    
    [Fact]
    public void PartialArticleTest()
    {
        Article article = Article.Make(1)
            .Phone(123456789)
            .Reference("123456")
            .Description("Article description")
            .RetailPrice(100)
            .Build();

        Assert.Equal(1, article.Id);
        Assert.Equal([123456789], article.Phones);
        Assert.Equal("123456", article.Reference);
        Assert.Equal("Article description", article.Description);
        Assert.Equal(100, article.RetailPrice);
        Assert.Equal(0, article.Stock);
        Assert.Equal(0, article.WholeSalePrice);
        Assert.Null(article.Tags);
    }
}