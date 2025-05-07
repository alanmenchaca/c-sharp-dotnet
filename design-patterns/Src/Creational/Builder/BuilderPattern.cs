namespace design_patterns.Creational.Builder;

/*
 * It makes sense to use the Builder pattern only when your products are quite complex
 * and require extensive configuration.
 * Unlike in other creational patterns, different concrete builders can produce unrelated
 * products.
 */
public class Product
{
    private readonly List<object> _parts = [];

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public string ListParts()
    {
        var partsListed = string.Join(", ", _parts);
        return $"Product parts: {partsListed}";
    }
}

/*
 * The Concrete Builder classes follow the Builder interface and provide specific
 * implementations of the building steps. Our program may have several variations
 * of Builders, implemented differently.
 */
public class BuilderPattern : IBuilderPattern
{
    private Product _product = new();

    // A fresh builder instance should contain a blank product object,
    // which is used in further assembly.
    public BuilderPattern()
    {
        Reset();
    }

    // All production steps work with the same product instance. 
    public IBuilderPattern BuildPartA()
    {
        _product.Add("PartA");
        return this;
    }

    public IBuilderPattern BuildPartB()
    {
        _product.Add("PartB");
        return this;
    }

    public IBuilderPattern BuildPartC()
    {
        _product.Add("PartC");
        return this;
    }

    private void Reset()
    {
        _product = new Product();
    }

    /*
     * Concrete Builders are supposed to provide their own methods for retrieving results.
     * That's because various types of builders may create entirely different products that
     * don't follow the same interface.
     * Therefore, such methods cannot be declared in the base Builder interface.
     */
    public Product GetProduct()
    {
        var product = _product;
        /*
         * Usually, after returning the end result to the client, a builder instance is
         * expected to be ready to start producing another product. That's why it's a usual
         * practice to call the reset method at the end of the 'GetProduct' method body.
         *
         */
        Reset();
        return product;
    }
}