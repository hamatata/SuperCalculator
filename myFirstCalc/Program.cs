using System;

namespace myFirstCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();           
            Console.WriteLine("Yahoo, look at our first Calculator: " + calc);

            int a = 5;
            int b = 6;
            int resSum = calc.add(a, b);
            Console.WriteLine(a + " + " + b + " = " + resSum);

            int resMmultiply = calc.multiply(a, b);
            Console.WriteLine(a + " * " + b + " = " + resMmultiply);

            int resSubstr = calc.minus(a, b);
            Console.WriteLine(a + " - " + b + " = " + resSubstr);
        }
    }
}
