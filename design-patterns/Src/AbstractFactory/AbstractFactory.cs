namespace design_patterns.AbstractFactory;

public abstract class AbstractFactory
{
    private static AbstractFactory? _abstractFactory;

    public static AbstractFactory? GetAbstractFactory()
    {
        return _abstractFactory;
    }

    public static void SetAbstractFactory(AbstractFactory? abstractFactory)
    {
        _abstractFactory = abstractFactory;
    }

    public abstract IProductA CreateProductA();
    public abstract IProductB CreateProductB();
}