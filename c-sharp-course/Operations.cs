namespace c_sharp_course;

public class Operations
{
    public static void DoOperations()
    {
        int age = 24;
        age++; // age = age + 1
        age += 10; // age = age + 10
        Console.WriteLine("Age: " + age);
        age--; // age = age - 1
        Console.WriteLine("Age: " + age);
        
        // +, -, *, /, %
        Console.WriteLine($"\nage + 3: {age + 3}");
        Console.WriteLine($"age - 14: {age - 14}");
        Console.WriteLine($"age * 2: {age * 2}");
        Console.WriteLine($"age / 3: {age / 3}");
        // modulus: remainder of division
        Console.WriteLine($"age % 2: {age % 2}");

        string name = "John";
        name += " Doe";
        Console.WriteLine($"\nFull Name: {name}");

        char ch = 'a';
        // unicode addition
        ch += 'b'; // 0061 + 0062 = 00C3
        Console.WriteLine($"Char: {ch}");

        int i = 0;
        Console.WriteLine($"\npost-increment i: {i++}");
        Console.WriteLine($"incremented i: {i}");
        Console.WriteLine($"pre-increment i: {++i}");
    }
}
