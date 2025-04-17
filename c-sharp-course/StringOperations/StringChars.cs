namespace c_sharp_course.StringOperations;

public class StringChars
{
    public static void RunProgram()
    {
        // '' is for char, "" is for string
        string name = "Alan Menchaca";
        char firstLetter = 'A';

        Console.WriteLine("Your Name is: " +  name);
        Console.WriteLine($"First Letter: {firstLetter}");
    }
}