namespace c_sharp_course.Exercises;

public class FizzBuzzGame
{
/*
 * Create a for loop from 1 to X (15)
 * 3 and 5 = FizzBuzz
 * 3 = Fizz
 * 5 = Buzz
 * else = number
 */
    public static void FizzBuzzExercise()
    {
        for (int i = 1; i <= 15; i++)
        {
            bool isThreeDiv = i % 3 == 0;
            bool isFiveDiv = i % 5 == 0;

            if (isThreeDiv && isFiveDiv)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (isThreeDiv)
            {
                Console.WriteLine("Fizz");
            }
            else if (isFiveDiv)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}