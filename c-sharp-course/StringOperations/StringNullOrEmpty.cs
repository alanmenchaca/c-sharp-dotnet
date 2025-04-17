namespace c_sharp_course.StringOperations;

public class StringNullOrEmpty
{
    public static void CheckIfStringIsEmpty()
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();

        Console.WriteLine($"Your name is {name}");

        // if (name != "")
        //     Console.WriteLine("string is not empty");

        // if (!name.Equals(""))
        //     Console.WriteLine("string is not empty");

        if (!string.IsNullOrEmpty(name)) // null or ""
            Console.WriteLine("string is not empty");
    }
}