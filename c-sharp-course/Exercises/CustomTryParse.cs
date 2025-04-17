namespace c_sharp_course.Exercises;

public class CustomTryParse
{
    /*
     * Create an int and try to convert any string to an int
     * Notice the error, write a try-catch handler around it
     * Catch the error and output the error message
     * Without changing the current code
     *
     * Why is this a bad situation and how can we know if it's been converted?
     *
     * Create a custom try parse function
     * Find the real function and copy return type/params
     * Read the tooltip it gives you, to give you ideas in what to do
     */
    public static void ParseIntExercise()
    {
        Console.Write("Please enter a number: ");
        // bool success = int.TryParse(Console.ReadLine(), out int number);
        bool success = CustomTryParseFunc(Console.ReadLine(), out int number);
        Console.WriteLine($"{success} - {number}");
    }

    private static bool CustomTryParseFunc(string? s, out int result)
    {
        result = 0;
        bool success = default;
        try
        {
            result = Convert.ToInt32(s);
            success = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return success;
    }
}