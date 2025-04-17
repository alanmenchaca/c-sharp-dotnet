namespace c_sharp_course.Exercises;

public class TimesTable
{
    /*
     * Ask the user for a number for the table
     * Write a for loop to print X times table
     */
    public static void TimesTableExercise()
    {
        Console.Write("Enter a number: ");
        int times = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{times} x {i} = {times * i}");
        }
    }
}