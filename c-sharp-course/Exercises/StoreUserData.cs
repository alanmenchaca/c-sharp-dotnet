namespace c_sharp_course.Exercises;

public class StoreUserData
{
/*
 * Define a variable to hold your name
 * Define a variable to hold your phone number
 * Define a variable to hold your age
 * Print variables line-by-line to the screen
 * Extra: define variables using the var keyword
 */
    public static void UserDataExercise()
    {
        string name = "John Doe";
        string phoneNumber = "123-456-7890";
        int age = 30;
        
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Phone Number: {phoneNumber}");
        Console.WriteLine($"Age: {age}");

        var randNumber = 42;
        var isMale = true;
        const double PI = 3.14159;
        
        Console.WriteLine($"\nRandom Number: {randNumber}");
        Console.WriteLine($"IsMale?: {isMale}");
        Console.WriteLine($"PI: {PI}");
    }
}