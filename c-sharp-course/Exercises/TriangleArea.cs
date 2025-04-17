namespace c_sharp_course.Exercises;

public class TriangleArea
{
    /*
     * Ask user for width and height, store them
     * Create function to calculate the area
     * Function should calculate the area using: (width * height) / 2
     * Call in the main and print out the area of the triangle
     */
    public static void CalculateTriangleAreaExercise()
    {
        Console.Write("Enter the width of the triangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = CalculateArea(width, height);
        Console.WriteLine($"The area of the triangle is: {area}");
    }

    private static double CalculateArea(double width, double height)
    {
        return (width * height) / 2;
    }
}