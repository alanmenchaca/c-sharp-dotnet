namespace c_sharp_course;

public class CondRelationalOp
{
    public static void WorkWithOperators()
    {
        // Console.Write("Enter your Name: ");
        // string? name = Console.ReadLine();
        //
        // Console.Write("Enter your Age: ");
        // int age = Convert.ToInt32(Console.ReadLine());
        //
        // // ==, !=, >, <, >=, <=
        // if (age >= 18 && age <= 25)
        // {
        //     Console.WriteLine("You are between 18 and 25");
        // }
        // else if (age >= 26)
        // {
        //     Console.WriteLine("You are 26 or older");
        // }
        //
        // if (age < 0 || age > 150)
        // {
        //     Console.WriteLine("Invalid Age!");
        // }
        // else
        // {
        //     Console.WriteLine("Valid Age!");
        // }
        
        Console.Write("Enter the first Number: ");
        int numA = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the second Number: ");
        int numB = Convert.ToInt32(Console.ReadLine());

        int answer = numA * numB;
        Console.Write($"Value of {numA} x {numB}: " );
        int userAnswer = Convert.ToInt32(Console.ReadLine());
        
        if (userAnswer == answer)
        {
            Console.WriteLine("Well done!");
        }
        else
        {
            Console.WriteLine("Close but it was wrong!");
        }
    }
}