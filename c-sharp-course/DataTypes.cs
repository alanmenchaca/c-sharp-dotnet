namespace c_sharp_course
{
    class DataTypes
    {
        public static void DisplayDataTypes()
        {
            Console.WriteLine("Hello, World!");

            // VAR and CONST keywords
            // var foo; Error: Implicitly-typed variables must be initialized
            var name = "John Doe";
            var bar = 42; // int by default
            var baz = 3.1416; // double by default
            
            const int VAT = 20;
            // VAT = 43; Error: A const field cannot be assigned to
            const double PCT_VAT = VAT / 100D;
            int balance = 1000;

            Console.WriteLine($"20% of the balance: {balance * PCT_VAT}\n");

            // ------------------------------------------
            
            int x = 10,
                y = 20,
                z = 30;

            // int, long, double, float, decimal
            int age = 24;
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"int.MaxValue: {int.MaxValue}");
            Console.WriteLine($"int.MinValue: {int.MinValue}");

            // L is used to specify that the number is a long
            long bigNumber = -17102000L;
            Console.WriteLine($"\nbigNumber: {bigNumber}");
            Console.WriteLine($"long.MaxValue: {long.MaxValue}");
            Console.WriteLine($"long.MinValue: {long.MinValue}");

            double negative = -42.2D;
            Console.WriteLine($"\nnegative double: {negative}");
            Console.WriteLine($"double.MaxValue: {double.MaxValue}");
            Console.WriteLine($"double.MinValue: {double.MinValue}");

            // F is used to specify that the number is a float
            float precision = 3.1416F;
            Console.WriteLine($"\nprecision float: {precision}");
            Console.WriteLine($"float.MaxValue: {float.MaxValue}");
            Console.WriteLine($"float.MinValue: {float.MinValue}");

            decimal money = 13.99M;
            Console.WriteLine($"\nmoney decimal: {money}");
            Console.WriteLine($"decimal.MaxValue: {decimal.MaxValue}");
            Console.WriteLine($"decimal.MinValue: {decimal.MinValue}");

            bool isMale = true;
            Console.WriteLine(isMale ? "\nMale" : "\nFemale");
        }
    }
}