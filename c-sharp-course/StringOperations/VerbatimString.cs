namespace c_sharp_course.StringOperations;

public class VerbatimString
{
    public static void FormatStrings()
    {
        string path = "C:\\Users\\alanm\\Documents\nNew line test";
        Console.WriteLine($"path: {path}");
        
        // \t, \n, \", \\
        string path2 = @"C:\Users\alanm\Documents" + "\nNew line test";

        string hello = @"Hello ""John Doe""";
        Console.WriteLine(hello);

        hello = "Hello 'John Doe'";
        Console.WriteLine(hello);
    }
}