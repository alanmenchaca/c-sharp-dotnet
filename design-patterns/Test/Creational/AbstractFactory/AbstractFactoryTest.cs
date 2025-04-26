using design_patterns.Creational.AbstractFactory;
using design_patterns.Creational.AbstractFactory.Concrete1;
using design_patterns.Creational.AbstractFactory.Concrete2;
using NUnit.Framework;

namespace design_patterns.Test.Creational.AbstractFactory;

public class AbstractFactoryTest
{
    [Test]
    public void ProductAOfConcrete1FactoryTest()
    {
        AbstractFactoryPattern.SetAbstractFactory(new Concrete1Factory());
        var productA = AbstractFactoryPattern.GetAbstractFactory().CreateProductA();
        Assert.That(productA.View(), Is.EqualTo("ProductA1"));
    }

    [Test]
    public void ProductBOfConcrete1FactoryTest()
    {
        AbstractFactoryPattern.SetAbstractFactory(new Concrete1Factory());
        var productB = AbstractFactoryPattern.GetAbstractFactory().CreateProductB();
        Assert.That(productB.View(), Is.EqualTo("ProductB1"));
    }

    [Test]
    public void ProductAOfConcrete2FactoryTest()
    {
        AbstractFactoryPattern.SetAbstractFactory(new Concrete2Factory());
        var productA = AbstractFactoryPattern.GetAbstractFactory().CreateProductA();
        Assert.That(productA.View(), Is.EqualTo("ProductA2"));
    }

    [Test]
    public void ProductBOfConcrete2FactoryTest()
    {
        AbstractFactoryPattern.SetAbstractFactory(new Concrete2Factory());
        var productB = AbstractFactoryPattern.GetAbstractFactory().CreateProductB();
        Assert.That(productB.View(), Is.EqualTo("ProductB2"));
    }
}