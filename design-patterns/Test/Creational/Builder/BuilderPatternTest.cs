using design_patterns.Creational.Builder;
using NUnit.Framework;

namespace design_patterns.Test.Creational.Builder;

public class BuilderPatternTest
{
    private BuilderPattern _builder;
    private BuilderDirector? _director;

    [SetUp]
    public void Setup()
    {
        _builder = new BuilderPattern();
        _director = new BuilderDirector { Builder = _builder };
    }

    [Test]
    public void BuildProductWithPartAAndPartB_ShouldReturnProductWithCorrectParts()
    {
        // Arrange
        _builder
            .BuildPartA()
            .BuildPartB();

        // Act
        var product = _builder.GetProduct();

        // Assert
        const string expected = "Product parts: PartA, PartB";
        Assert.Multiple(() =>
        {
            Assert.That(product, Is.TypeOf<Product>());
            Assert.That(product.ListParts(), Is.EqualTo(expected));
        });
    }

    [Test]
    public void BuildMinimalViableProduct_ShouldReturnProductWithPartAOnly()
    {
        // Arrange
        _director?.BuildMinimalViableProduct();

        // Act
        var product = _builder.GetProduct();

        // Assert
        const string expected = "Product parts: PartA";
        var actual = product.ListParts();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void BuildFullFeaturedProduct_ShouldReturnProductWithAllParts()
    {
        // Arrange
        _director?.BuildFullFeaturedProduct();

        // Act
        var product = _builder.GetProduct();

        // Assert
        var actual = product.ListParts();
        const string expected = "Product parts: PartA, PartB, PartC";

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetProduct_ShouldReturnNewInstance_AfterEachBuild()
    {
        // Arrange
        _director?.BuildMinimalViableProduct();

        // Act
        var firstProduct = _builder.GetProduct();
        var secondProduct = _builder.GetProduct();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(firstProduct, Is.Not.Null);
            Assert.That(secondProduct, Is.Not.Null);
            Assert.That(firstProduct, Is.Not.EqualTo(secondProduct));
        });
    }

    [TearDown]
    public void TearDown()
    {
        _builder = null;
        _director = null;
    }
}