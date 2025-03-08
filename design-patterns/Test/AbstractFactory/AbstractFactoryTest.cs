using design_patterns.AbstractFactory.Concrete2;

namespace design_patterns.Test.AbstractFactory;

using design_patterns.AbstractFactory;
using design_patterns.AbstractFactory.Concrete1;

public class AbstractFactoryTest
{
    [Fact]
    public void ProductAOfConcrete1FactoryTest()
    {
        AbstractFactory.SetAbstractFactory(new Concrete1Factory());
        Assert.Equal("ProductA1", AbstractFactory
            .GetAbstractFactory()?
            .CreateProductA()
            .View());
    }

    [Fact]
    public void ProductBOfConcrete1FactoryTest()
    {
        AbstractFactory.SetAbstractFactory(new Concrete1Factory());
        Assert.Equal("ProductB1", AbstractFactory
            .GetAbstractFactory()?
            .CreateProductB()
            .View());
    }

    [Fact]
    public void ProductAOfConcrete2FactoryTest()
    {
        AbstractFactory.SetAbstractFactory(new Concrete2Factory());
        Assert.Equal("ProductA2", AbstractFactory
            .GetAbstractFactory()?
            .CreateProductA()
            .View());
    }

    [Fact]
    public void ProductBOfConcrete2FactoryTest()
    {
        AbstractFactory.SetAbstractFactory(new Concrete2Factory());
        Assert.Equal("ProductB2", AbstractFactory
            .GetAbstractFactory()?
            .CreateProductB()
            .View());
    }
}