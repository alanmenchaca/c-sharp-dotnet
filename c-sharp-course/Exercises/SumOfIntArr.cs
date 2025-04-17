namespace c_sharp_course.Exercises;

public class SumOfIntArr
{
    /*
     * Create and initialize int array of numbers
     * Create function SumOfNumbers with int return type
     * int array param
     * function should return total of all numbers
     * call in main and output the total
     * extra: check array length
     * return -1 if array empty
     * check return in main and output message
     * do we need to return -1, how else can we make this?
     */
    public static void SumArrExercise()
    {
        int[] numbers = [1, 2, 3, 4, 5];
        bool success = SumOfNumbers(numbers, out int total);

        if (success)
        {
            Console.WriteLine("Total of numbers: " + total);
        }
        else
        {
            Console.WriteLine("The Array cannot be empty");
        }
    }

    private static bool SumOfNumbers(int[] numbers, out int total)
    {
        bool isArrEmpty = numbers.Length == 0;
        total = isArrEmpty ? -1 : numbers.Sum();
        return isArrEmpty;
    }
}