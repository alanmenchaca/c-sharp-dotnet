namespace c_sharp_course.Functions;

public class OutParams
{
    public static void UseOutParam()
    {
        // int num = 0;
        // bool success = Test(out num);
        // Console.WriteLine($"Success: {success}, num: {num}");

        List<string> shoppingList = ["Milk", "Bread", "Eggs"];

        Console.Write("Enter an item to search: ");
        string? search = Console.ReadLine();
        
        Console.WriteLine(shoppingList.IndexOf(search));
        bool success = FindInList(search, shoppingList, out int index);
        Console.WriteLine($"Success: {success}, index: {index}");
    }

    private static bool Test(out int num)
    {
        num = 5;
        return true;
    }

    private static bool FindInList(string s, List<string> list, out int index)
    {
        index = -1;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].ToLower().Equals(s.ToLower()))
            {
                index = i;
            }
        }

        return index > -1;
    }
}