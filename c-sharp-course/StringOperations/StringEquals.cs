namespace c_sharp_course.StringOperations;

public class StringEquals
{
    public static void CompareStrings()
    {
        string message = "Hello";
        string compare = "Hello";

        if (message.Equals(compare))
        {
            Console.WriteLine("The strings are equal");
        }
        else
        {
            Console.WriteLine("The strings are not equal");
        }

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        if (!name.Equals(""))
        {
            Console.WriteLine($"Your name is {name}");
        }
        else
        {
            Console.WriteLine("Invalid name input");
        }

        char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
        object newCompare = new string(chars);

        // comparing memory references not the actual values
        if (message == newCompare)
        {
            Console.WriteLine("Same");
        }
        else
        {
            Console.WriteLine("Different");
        }
    }
}