namespace ConsoleApp1.SolidPrinciples;

/*
 * The Open/Closed Principle suggests that a class should be open for
 * extension but closed for modification. This means we can add new
 * features without altering the existing code.
 * Key Idea: Once a class is written, it should be closed
 * for modifications but open for extensions.
 */
public class OpenClosedPrinciple
{
    /*
     * This design may become problematic when adding new shapes.
     * Modifying the AreaCalculator class for each new shape violates
     * the Open/Closed Principle.
     */
    // public class Rectangle
    // {
    //     public double Width { get; set; }
    //     public double Height { get; set; }
    // }

    public class AreaCalculator
    {
        public double CalculateArea(Rectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }
    }

    /*
     * To solve the problem, we can create a new interface called IShape
     * that defines a method to calculate the area of a shape. Then, we
     * can create a new class for each shape that implements the IShape
     * interface.
     */
    public interface IShape
    {
        double CalculateArea();
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
    
    /*
     * By introducing an interface (IShape), new shapes like Circle 
     * can be added without modifying existing code, adhering to the OCP.
     *
     * Explanation: According to OCP, the class should be open for extension
     * but closed for modification. So, when we introduce a new shape, then
     * just implement it from the interface IShape. So IShape is open for
     * extension but closed for further modification.
     */
}