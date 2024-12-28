namespace c_sharp_course;

public class TryParse
{
    public static void ParseANumber()
    {
        bool success = false;
        
        do
        {
            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine();

            bool isParsed = int.TryParse(numInput, out int num);

            if (isParsed)
            {
                success = true;
                Console.WriteLine("The number is: " + num);
            }
            else
            {
                Console.WriteLine("Failed to convert!\n");
            }
        } while (!success);
    }
}