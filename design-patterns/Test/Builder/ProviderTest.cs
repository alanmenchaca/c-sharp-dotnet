using design_patterns.Builder.Article.Solution;

namespace design_patterns.Test.Builder;

public class ProviderTest
{
    [Fact]
    public void FullProviderTest()
    {
        Provider provider = Provider.Make()
            .Id("1")
            .Company("Company")
            .Description("Provider description")
            .Nif("123456789")
            .Address("Address")
            .Phone("987654321")
            .Email("JohnDoe@gmail.com")
            .Note("Note")
            .Build();
        
        Assert.Equal("1", provider.Id);
        Assert.Equal("Company", provider.Company);
        Assert.Equal("Provider description", provider.Description);
        Assert.Equal("123456789", provider.Nif);
        Assert.Equal("Address", provider.Address);
        Assert.Equal("987654321", provider.Phone);
        Assert.Equal("JohnDoe@gmail.com", provider.Email);
        Assert.Equal("Note", provider.Note);
    }
    
    [Fact]
    public void PartialProviderTest()
    {
        Provider provider = Provider.Make()
            .Id("1")
            .Company("Company")
            .Build();
        
        Assert.Equal("1", provider.Id);
        Assert.Equal("Company", provider.Company);
        Assert.Null(provider.Description);
        Assert.Null(provider.Nif);
        Assert.Null(provider.Address);
        Assert.Null(provider.Phone);
        Assert.Null(provider.Email);
        Assert.Null(provider.Note);
    }
}