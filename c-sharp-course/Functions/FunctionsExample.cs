namespace c_sharp_course.Functions;

public class FunctionsExample
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Hello World!");
    }


    public static void CreateAndPrintArray()
    {
        int[] numbers = new int[5] { 0, 1, 2, 3, 4 };
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }
    }

    // return type functions
    public static void PrintIntroduction()
    {
        string name = ReturnName();
        Console.Title = name;
        Console.WriteLine($"Hello my name is {name}");

        int[] numbers = new int[3];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = ReadNumberFromConsole();
        }

        foreach (int item in numbers)
        {
            Console.Write($"{item} ");
        }
    }

    private static string ReturnName()
    {
        return "John Doe";
    }

    private static int ReadNumberFromConsole()
    {
        Console.Write("Enter a number: ");
        return Convert.ToInt32(Console.ReadLine());
    }
}