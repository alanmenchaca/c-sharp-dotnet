namespace design_patterns.AbstractFactory.Concrete1;

public class Concrete1Factory : AbstractFactory
{
    private IProductA? _productA;
    private IProductB? _productB;

    public override IProductA CreateProductA()
    {
        if (_productA == null)
            _productA = new ProductA1();
        return _productA;
    }

    public override IProductB CreateProductB()
    {
        if (_productB == null)
            _productB = new ProductB1();
        return _productB;
    }

    public override string ToString()
    {
        return "ConcreteFactory1";
    }
}