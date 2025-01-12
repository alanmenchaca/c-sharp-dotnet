namespace design_patterns.Builder.User.AdvancedSolution;

/*
 * This interface is used to create a fluent interface to build a User object.
 * The User is forced to be built with an Id, Nick and Name. 
 */
public interface IUserBuilders
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
        User Build();
    }
}