namespace design_patterns.Creational.AbstractFactory.Concrete1;

public class Concrete1Factory : AbstractFactoryPattern
{
    private IProductA? _productA;
    private IProductB? _productB;

    public override IProductA CreateProductA()
    {
        _productA ??= new ProductA1();
        return _productA;
    }

    public override IProductB CreateProductB()
    {
        _productB ??= new ProductB1();
        return _productB;
    }

    public override string ToString()
    {
        return "ConcreteFactory1";
    }
}