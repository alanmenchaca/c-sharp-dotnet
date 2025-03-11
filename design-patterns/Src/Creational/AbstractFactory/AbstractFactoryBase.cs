namespace design_patterns.Creational.AbstractFactory;

public abstract class AbstractFactoryBase
{
    private static AbstractFactoryBase? _abstractFactory;

    public static AbstractFactoryBase? GetAbstractFactory()
    {
        return _abstractFactory;
    }

    public static void SetAbstractFactory(AbstractFactoryBase? abstractFactory)
    {
        _abstractFactory = abstractFactory;
    }

    public abstract IProductA CreateProductA();
    public abstract IProductB CreateProductB();
}