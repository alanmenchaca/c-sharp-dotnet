namespace c_sharp_course.StringOperations;

public class StringIteration
{
    public static void IterateString()
    {
        string message = "C# is awesome!";
        Console.WriteLine("Message: " + message);

        Console.WriteLine(message[0]); // C
        Console.WriteLine(message[1]); // #

        for (int i = 0; i < message.Length; i++)
        {
            Console.Write($"{message[i]} ");
            Thread.Sleep(250);
        }
        
        Console.WriteLine();
        Console.WriteLine(message.Contains("C")); // True

        bool contains = false;
        for (int i = 0; i < message.Length; i++)
        {
            if (message[i].Equals('C'))
            {
                contains = true;
            }
        }

        Console.WriteLine(contains); // True
    }
}