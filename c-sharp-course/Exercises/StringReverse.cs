namespace c_sharp_course.Exercises;

public class StringReverse
{
    public static void ReverseStringExercise()
    {
        /*
         * Ask user to input message
         * Print in order
         * Print in reverse
         */
        Console.WriteLine("Enter a string to reverse: ");
        string? message = Console.ReadLine();

        Console.Write($"Original message: ");

        for (int i = 0; i < message.Length; i++)
        {
            Console.Write(message[i]);
        }

        Console.Write($"\nReversed message: ");
        for (int i = message.Length - 1; i >= 0; i--)
        {
            Console.Write(message[i]);
        }
    }
}