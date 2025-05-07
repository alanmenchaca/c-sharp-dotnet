namespace design_patterns.Creational.Builder;

/*
 * The director is only responsible for executing the building steps in a particular
 * sequence. It is helpful when producing products according to a specific order or
 * configuration.
 * The Director class is optional, since the client can control builders directly.
 */
public class BuilderDirector
{
    public IBuilderPattern Builder { private get; set; }

    public void BuildMinimalViableProduct()
    {
        Builder.BuildPartA();
    }

    public void BuildFullFeaturedProduct()
    {
        Builder.BuildPartA();
        Builder.BuildPartB();
        Builder.BuildPartC();
    }
}