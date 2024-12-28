namespace c_sharp_course.Exercises;

public class OddEvenSplit
{
    /*
     * Create two lists with integer data type, one for even numbers,
     * one for odd numbers. Loop from 0 to 20.
     *      * if number is even, add to even list
     *      * if number is odd, add to odd list
     * Print even list
     * Print odd list
     */
    public static void OddEvenSplitExercise()
    {
        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();

        for (int i = 0; i < 20; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers.Add(i);
            }
            else
            {
                oddNumbers.Add(i);
            }
        }

        Console.WriteLine("Even numbers:");
        foreach (int evenNumber in evenNumbers)
        {
            Console.Write($"{evenNumber} ");
        }

        Console.WriteLine("\nOdd numbers:");
        foreach (int oddNumber in oddNumbers)
        {
            Console.Write($"{oddNumber} ");
        }
        
    }
}