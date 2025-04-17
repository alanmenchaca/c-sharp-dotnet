namespace c_sharp_course;

public class ConsoleIO
{
    public static void ReadUserInput()
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"Hello, {name}! You are {age} years old.");
    }
}