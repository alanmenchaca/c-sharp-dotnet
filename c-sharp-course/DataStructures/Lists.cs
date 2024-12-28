namespace c_sharp_course.DataStructures;

public class Lists
{
    public static void WorkWithLists()
    {
        int[] numbers = new int[3]
        {
            1, 2, 3
        };

        List<int> listNumbers = new List<int>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter a number: ");
            listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
        }

        listNumbers.RemoveAt(0);
        foreach (int item in listNumbers)
        {
            Console.Write($"{item} ");
        }
    }
}