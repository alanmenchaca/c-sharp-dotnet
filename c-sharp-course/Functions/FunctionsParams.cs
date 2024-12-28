namespace c_sharp_course.Functions;

public class FunctionsParams
{
    public static void RunFunctions()
    {
        // int num1 = _ReadInt("Enter a number");
        // Console.WriteLine($"num: {num1}");
        //
        // int num2 = _ReadInt("Enter an angle");
        // Console.WriteLine($"angle: {num2}");

        int firstNum = _ReadInt("Enter first number");
        int secondNum = _ReadInt("Enter second number");
        int result = _Add(firstNum, secondNum);
        Console.WriteLine(result);

        string? name = _ReadString("Enter your name");
        int age = _ReadInt("Enter your age");
        string details = _UserDetails(name, age);
        Console.WriteLine(details);
    }

    private static int _ReadInt(string msg)
    {
        Console.Write($"{msg}: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    private static string? _ReadString(string msg)
    {
        Console.Write($"{msg}: ");
        return Console.ReadLine();
    }

    private static int _Add(int a, int b)
    {
        return a + b;
    }

    private static string _UserDetails(string? name, int age)
    {
        return $"Hello my name is {name} and my age is {age}!";
    }
}