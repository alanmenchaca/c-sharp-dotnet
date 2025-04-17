using Humanizer;

namespace c_sharp_course;

public class PkgHumanizer
{
    // dotnet add package Humanizer --version 3.0.0-beta.54
    public static void UsingHumanizer()
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        var cultureInfo = new System.Globalization.CultureInfo("en-US");
        // var cultureInfo = new System.Globalization.CultureInfo("es-MX");
        Console.WriteLine($"Hello {name}, you are {age.ToWords(cultureInfo)} years old.");
    }
}