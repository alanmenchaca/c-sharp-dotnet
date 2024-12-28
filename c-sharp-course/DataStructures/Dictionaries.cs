namespace c_sharp_course.DataStructures;

public class Dictionaries
{
    public static void WorkWithDictionaries()
    {
        /*Dictionary<int, string> names = new Dictionary<int, string>
        {
            { 1, "John" },
            { 2, "Jane" },
            { 3, "Alan" }
        };
        // names.Add(3, "Alan"); this will throw an exception

        for (int i = 0; i < names.Count; i++)
        {
            KeyValuePair<int, string> name = names.ElementAt(i);
            Console.WriteLine($"Key: {name.Key}, Value: {name.Value}");
        }

        Console.WriteLine("\nForeach loop:");
        foreach (KeyValuePair<int, string> name in names)
        {
            Console.WriteLine($"Key: {name.Key}, Value: {name.Value}");
        }*/

        Dictionary<string, string> teachers = new Dictionary<string, string>()
        {
            { "Math", "John" },
            { "English", "Jane" },
            { "Science", "Alan" }
        };

        if (teachers.TryGetValue("Science", out string teacher))
        {
            Console.WriteLine(teacher);
            teachers["Science"] = "Joe";
        }
        else
        {
            Console.WriteLine("Teacher not found");
        }

        if (teachers.ContainsKey("Math"))
        {
            teachers.Remove("Math");
        }
        else
        {
            Console.WriteLine("Key not found");
        }

        foreach (KeyValuePair<string, string> item in teachers)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }
}