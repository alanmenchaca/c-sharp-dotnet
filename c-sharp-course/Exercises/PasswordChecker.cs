namespace c_sharp_course.Exercises;

public class PasswordChecker
{
    /*
     * Ask user to enter a password, and store
     * Ask user to enter a password again, and store
     * Check if they are the same
     *      * If so, check if they are the same
     *          * If they are, print "Passwords match"
     *          * If they are not, print "Passwords do not match"
     *      * If they are empty, print "Please enter a password"
     */
    public static void CheckPasswordExercise()
    {
        Console.Write("Please enter a password: ");
        string? password = Console.ReadLine();

        Console.Write("Please confirm your password: ");
        string? confirmPassword = Console.ReadLine();

        if (!string.IsNullOrEmpty(password) &&
            !string.IsNullOrEmpty(confirmPassword))
        {
            if (password.Equals(confirmPassword))
            {
                Console.WriteLine("Passwords match");
            }
            else
            {
                Console.WriteLine("Passwords do not match");
            }
        }
        else
        {
            Console.WriteLine("Please enter a password");
        }
    }
}