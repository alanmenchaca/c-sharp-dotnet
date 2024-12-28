namespace c_sharp_course.Arrays;

public class ArraysExample
{
    public static void ShowArrays()
    {
        // int num1 = 5;
        // int num2 = 10;
        // int num3 = 15;

        /*Console.Write("Enter a number: ");
        numbers[0] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a number: ");
        numbers[1] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a number: ");
        numbers[2] = Convert.ToInt32(Console.ReadLine());*/

        // Console.WriteLine($"{num1} {num2} {num3}");
        // Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

        int[] numbers = new int[3];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter a number: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }

        Console.WriteLine();
        foreach (var num in numbers)
        {
            Console.Write($"{num} ");
        }
    }

    public static void TriangleAnglesSum()
    {
        // Console.Write("Enter angle 1: ");
        // int angle1 = Convert.ToInt32(Console.ReadLine());
        //
        // Console.Write("Enter angle 2: ");
        // int angle2 = Convert.ToInt32(Console.ReadLine());
        //
        // Console.Write("Enter angle 3: ");
        // int angle3 = Convert.ToInt32(Console.ReadLine());

        // int angleSum = angle1 + angle2 + angle3;

        const int ANGLE_COUNT = 3;
        int angleSum = 0;

        for (int i = 0; i < ANGLE_COUNT; i++)
        {
            Console.Write($"Enter angle {i + 1}: ");
            angleSum += Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");
    }
}