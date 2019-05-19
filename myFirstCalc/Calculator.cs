using System;

namespace myFirstCalc
{
    public class Calculator
    {
        public int operand1 { get; set; }
        public int operand2 { get; set; }

        public Calculator()
        {
        }

        // Operations

        public int add()
        {
            return operand1 + operand2;
        }

        public int multiply()
        {
            return operand1 * operand2;
        }

        public int minus()
        {
            return operand1 - operand2;
        }

    }

}