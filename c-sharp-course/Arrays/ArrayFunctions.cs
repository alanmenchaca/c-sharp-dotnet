namespace c_sharp_course.Arrays;

public class ArrayFunctions
{
    public static void SortArray()
    {
        int[] numbers = [9, 2, 0, 5, 5, 6, 7, 8, 9];
        Array.Sort(numbers);

        foreach (var num in numbers)
        {
            Console.Write($"{num} ");
        }
    }

    public static void ReverseArray()
    {
        int[] numbers = [0, 1, 2, 3, 4, 5];
        Array.Reverse(numbers);

        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
    }

    public static void ClearingArray()
    {
        int[] numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        // Array.Clear(numbers, 0, numbers.Length);

        Array.Clear(numbers, 5, 5);

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = default;            
        // }

        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
    }

    public static void IndexOfInArray()
    {
        int[] numbers = [90, 199, 22, 50, 30];

        Console.Write("Enter the number to search: ");
        int search = Convert.ToInt32(Console.ReadLine());
        // int pos = Array.IndexOf(numbers, search);
        // int pos = Array.IndexOf(numbers, search, 2);
        int pos = Array.IndexOf(numbers, search, 0, 2);

        if (pos > -1)
        {
            Console.WriteLine($"Number {search} has been found at position {pos}");
        }
        else
        {
            Console.WriteLine($"Number {search} has not been found!");
        }
    }
}