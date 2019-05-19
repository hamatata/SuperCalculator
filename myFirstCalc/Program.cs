using System;

namespace myFirstCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();           
            Console.WriteLine("Yahoo, look at our first Calculator: " + calc);

            calc.operand1 = 5;
            calc.operand2 = 6;
            int resSum = calc.add();
            Console.WriteLine(calc.operand1 + " + " + calc.operand2 + " = " + resSum);

            int resMmultiply = calc.multiply();
            Console.WriteLine(calc.operand1 + " * " + calc.operand2 + " = " + resMmultiply);

            int resSubstr = calc.minus();
            Console.WriteLine(calc.operand1 + " - " + calc.operand2 + " = " + resSubstr);
        }
    }
}
