namespace c_sharp_course.Functions;

public class RefParams
{
    public static void ReferenceParameters()
    {
        int num = 10;
        string name = "John";

        Console.WriteLine($"num: {num}");
        Console.WriteLine($"name: {name}");

        Assign(ref num, ref name);

        Console.WriteLine($"\nnum: {num}");
        Console.WriteLine($"name: {name}");

        Console.WriteLine(ChangeName(ref name, "Alan")
            ? $"\nYour new name is {name}!"
            : "\nNew name cannot be empty or null!");
    }

    // ref: The parameter passed with "ref" must be initialized before
    // it is passed to the method.

    // out: The parameter passed with "out" does not need to be initialized
    // before passing it to the method, but the method must assign a value
    // to it before the method ends.
    private static void Assign(ref int num, ref string name)
    {
        num = 20;
        name = "Jane";
    }

    private static bool ChangeName(ref string name, string newName)
    {
        bool isValidName = !string.IsNullOrEmpty(newName);
        if (isValidName)
        {
            name = newName;
        }

        return isValidName;
    }
}