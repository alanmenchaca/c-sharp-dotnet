namespace c_sharp_course.Functions;

public class OptionalParams
{
    public static void DisplayUserData()
    {
        int result = _Add(5);
        Console.WriteLine($"result: {result}");

        _PrintName();
        _PrintName("Jane Doe");

        string nameInput = "John Doe";
        int ageInput = 30;
        string addressInput = "123 Main St";

        Console.WriteLine("\nNamed arguments:");
        _PrintDetails(nameInput, ageInput, addressInput);
        _PrintDetails(
            age: ageInput,
            name: nameInput,
            address: addressInput);
    }

    // optional arguments
    private static int _Add(int a, int b = default)
    {
        Console.WriteLine($"a: {a}, b: {b}");
        return a + b;
    }

    private static void _PrintName(string name = "John Doe")
    {
        Console.WriteLine($"Hello my name is {name}");
    }

    // named arguments
    private static void _PrintDetails(string name, int age, string address)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Address: {address}");
    }
}