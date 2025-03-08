namespace design_patterns.AbstractFactory.Concrete2;

public class Concrete2Factory : AbstractFactory
{
    private IProductA? _productA;
    private IProductB? _productB;

    public override IProductA CreateProductA()
    {
        if (_productA == null)
            _productA = new ProductA2();
        return _productA;
    }

    public override IProductB CreateProductB()
    {
        if (_productB == null)
            _productB = new ProductB2();
        return _productB;
    }
}