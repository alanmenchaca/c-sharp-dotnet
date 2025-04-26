namespace design_patterns.Creational.Builder.Client;

/*
 * This interface is used to create a fluent interface to build a Client object.
 * The Client is forced to be built with an Id, Nick and Name.
 */
public interface IClientBuilders
{
    interface ID
    {
        INick Id(string id);
    }

    interface INick
    {
        IName Nick(string nick);
    }

    interface IName
    {
        IOptionals Name(string name);
    }

    interface IOptionals
    {
        IOptionals FamilyName(string familyName);
        IOptionals Age(int age);
        IOptionals Phone(int phone);
        IOptionals Profession(string profession);
        IOptionals Tag(string tag);
        ClientBuilder Build();
    }
}