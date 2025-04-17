namespace c_sharp_course.Exercises;

public class OddEvenChecker
{
/*
 * Create and initialize two inits
 * Make a variable to work out the remainder
 * Output remainder to the console
 * Change the first int variable to another number
    * and recalculate the remainder  
    * output the new remainder to the console
 */

    public static void OddEvenCheckerExercise()
    {
        int numerator = 10;
        int denominator = 2;
        int remainder = numerator % denominator;
        Console.WriteLine($"Remainder: {remainder}");
        
        numerator = 11;
        remainder = numerator % denominator;
        Console.WriteLine($"Remainder: {remainder}");
    }
}
