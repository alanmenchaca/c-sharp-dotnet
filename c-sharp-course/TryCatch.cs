namespace c_sharp_course;

public class TryCatch
{
    public static void TestTryCatchClause()
    {
        bool looping = true;
        while (looping)
        {
            try
            {
                Console.Write("Enter a number: ");
                // select .ToInt32 to see the possible exceptions
                int num = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine($"You entered: {num}");
                looping = false;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Please enter only numbers!\n");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                Console.WriteLine($"Please enter a number less than {int.MaxValue}\n");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                
            }
        }
    }
}