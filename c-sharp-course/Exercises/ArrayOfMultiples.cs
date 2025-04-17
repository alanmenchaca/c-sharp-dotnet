namespace c_sharp_course.Exercises;

public class ArrayOfMultiples
{
    /*
     * Define and initialize two integers (num, length)
     * (7, 5) -> [7, 14, 21, 28, 35]
     * Create int array with size length loop through and
     *  insert the (loop counter x num) into the array
     * print the final array
     */
    public static void ArrayOfMultiplesExercise()
    {
        int num = 7;
        int length = 5;
        int[] arrayOfMultiples = new int[length];

        for (int i = 1; i <= length; i++)
        {
            arrayOfMultiples[(i - 1)] = num * i;
        }

        Console.WriteLine("Array of multiples: ");
        foreach (var multiple in arrayOfMultiples)
        {
            Console.Write($"{multiple} ");
        }
    }
}