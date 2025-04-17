using System.Globalization;

namespace c_sharp_course.StringOperations;

public class Format
{
    public static void ShowFormats()
    {
        double value = 1000D / 12.34D;

        Console.WriteLine(string.Format("{0}", value));
        Console.WriteLine(string.Format("{0} {1}", value, 1000));

        Console.WriteLine("\nDecimal places: ");
        Console.WriteLine(string.Format("{0:0}", value));
        Console.WriteLine(string.Format("{0:0.0}", value));
        Console.WriteLine(string.Format("{0:0.00}", value));

        Console.WriteLine("\nCurrency Formating: ");
        double money = -10D / 3D; // or 10.0 / 3.0
        Console.WriteLine($"Money: {money}");
        Console.WriteLine(string.Format("{0:0.00}", money));
        Console.WriteLine($"Money as Currency: {money.ToString("C")}\n");

        Console.WriteLine(money.ToString("C1"));
        Console.WriteLine(money.ToString("C2"));

        Console.WriteLine(money.ToString("C",
            CultureInfo.CurrentCulture));
        Console.WriteLine($"en-GB: {money.ToString("C2", CultureInfo.CreateSpecificCulture("en-GB"))}");
        Console.WriteLine($"en-US: {money.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))}");
        Console.WriteLine($"en-AU: {money.ToString("C2", CultureInfo.CreateSpecificCulture("en-AU"))}");
    }
}