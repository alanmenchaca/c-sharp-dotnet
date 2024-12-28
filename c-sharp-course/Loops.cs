namespace c_sharp_course;

public class Loops
{
    public static void RunForLoops()
    {
        Console.Write("What do you want to repeat?: ");
        string? message = Console.ReadLine();

        Console.Write($"And how many times do you want to repeat it?: ");
        int loopCounter = Convert.ToInt32(Console.ReadLine());

        if (loopCounter <= 0)
        {
            Console.WriteLine("Sorry, please enter a value grater than 0.");
        }
        else
        {
            for (int i = 0; i < loopCounter; i++)
            {
                Console.WriteLine("Hello World!");
            }
        }

        // Console.WriteLine();
        // for (int i = 1; i <= 10; i += 2)
        // {
        //     Console.Write($"{i}, ");
        // }
    }

    public static void RunWhileLoops()
    {
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.Write($"{i}, ");
        // }

        Console.Write("Enter the first Number: ");
        int numA = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second Number: ");
        int numB = Convert.ToInt32(Console.ReadLine());

        int answer = numA * numB;
        Console.WriteLine($"\nWhats the value of {numA} x {numB}?");

        int userAnswer = 0;
        int i = 0;

        // while (answer != userAnswer)
        // {
        //     Console.Write("Enter your answer: ");
        //     userAnswer = Convert.ToInt32(Console.ReadLine());
        //
        //     if (userAnswer != answer)
        //     {
        //         Console.WriteLine("Close but it was wrong!\n");
        //     }
        // }

        do
        {
            Console.Write("Enter your answer: ");
            userAnswer = Convert.ToInt32(Console.ReadLine());

            if (userAnswer != answer)
            {
                Console.WriteLine("Close but it was wrong!\n");
            }
        } while (answer != userAnswer);

        Console.WriteLine("Well done!");

        // using of ternary operator
        int age = 24;
        string result = age >= 18 ? "Valid" : "Invalid";
        Console.WriteLine(result);
    }
}