namespace c_sharp_course;

public class Conversions
{
    public static void ShowConversions()
    {
        string textAge = "-24";
        
        int age = Convert.ToInt32(textAge);
        Console.WriteLine(age);
        
        string textBigNumber = "-17102000";
        // explicitly convert to long
        long bigNumber = Convert.ToInt64(textBigNumber); 
        Console.WriteLine(bigNumber);
        
        string textNegative = "-42.2";
        double negative = Convert.ToDouble(textNegative);
        Console.WriteLine(negative);
        
        string textPrecision = "3.1416";
        float precision = Convert.ToSingle(textPrecision);
        Console.WriteLine(precision);
        
        string textMoney = "13.99";
        decimal money = Convert.ToDecimal(textMoney);
        Console.WriteLine(money);
    }
}