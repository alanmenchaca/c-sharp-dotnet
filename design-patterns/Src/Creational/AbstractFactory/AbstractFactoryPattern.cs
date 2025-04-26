namespace design_patterns.Creational.AbstractFactory;

public abstract class AbstractFactoryPattern
{
    private static AbstractFactoryPattern _abstractFactory;

    public static AbstractFactoryPattern GetAbstractFactory()
    {
        return _abstractFactory;
    }

    public static void SetAbstractFactory(AbstractFactoryPattern abstractFactory)
    {
        _abstractFactory = abstractFactory;
    }

    public abstract IProductA CreateProductA();
    public abstract IProductB CreateProductB();
}