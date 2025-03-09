using design_patterns.AbstractFactory.Concrete2;
using NUnit.Framework;

namespace design_patterns.Test.AbstractFactory;

using design_patterns.AbstractFactory;
using design_patterns.AbstractFactory.Concrete1;

public class AbstractFactoryTest
{
    [Test]
    public void ProductAOfConcrete1FactoryTest()
    {
        AbstractFactory.SetAbstractFactory(new Concrete1Factory());
        var productA = AbstractFactory.GetAbstractFactory()?.CreateProductA();
        Assert.That(productA?.View(), Is.EqualTo("ProductA1"));
    }

    [Test]
    public void ProductBOfConcrete1FactoryTest()
    {
        AbstractFactory.SetAbstractFactory(new Concrete1Factory());
        var productB = AbstractFactory.GetAbstractFactory()?.CreateProductB();
        Assert.That(productB?.View(), Is.EqualTo("ProductB1"));
    }

    [Test]
    public void ProductAOfConcrete2FactoryTest()
    {
        AbstractFactory.SetAbstractFactory(new Concrete2Factory());
        var productA = AbstractFactory.GetAbstractFactory()?.CreateProductA();
        Assert.That(productA?.View(), Is.EqualTo("ProductA2"));
    }

    [Test]
    public void ProductBOfConcrete2FactoryTest()
    {
        AbstractFactory.SetAbstractFactory(new Concrete2Factory());
        var productB = AbstractFactory.GetAbstractFactory()?.CreateProductB();
        Assert.That(productB?.View(), Is.EqualTo("ProductB2"));
    }
}