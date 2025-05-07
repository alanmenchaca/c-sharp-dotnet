namespace design_patterns.Creational.Builder;

public interface IBuilderPattern
{
    // The Builder interface specifies methods for creating the different parts
    // of the product.
    IBuilderPattern BuildPartA();
    IBuilderPattern BuildPartB();
    IBuilderPattern BuildPartC();
}