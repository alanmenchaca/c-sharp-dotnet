namespace design_patterns.Creational.AbstractFactory.Concrete2;

public class Concrete2Factory : AbstractFactoryPattern
{
    private IProductA? _productA;
    private IProductB? _productB;

    public override IProductA CreateProductA()
    {
        _productA ??= new ProductA2();
        return _productA;
    }

    public override IProductB CreateProductB()
    {
        _productB ??= new ProductB2();
        return _productB;
    }
}