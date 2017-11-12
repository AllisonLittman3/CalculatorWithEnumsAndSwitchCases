using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithEnumsAndSwitchCases
{
    class Calculator
    {
        public decimal Add(decimal number1, decimal number2)
        {
            decimal answer = number1 + number2;
            return answer;
        }

        public decimal Subtract(decimal number1, decimal number2)
        {
            decimal answer = number1 - number2;
            return answer;
        }

        public decimal Divide(decimal number1, decimal number2)
        {
            decimal answer = number1 / number2;
            return answer;
        }

        public decimal Multiply(decimal number1, decimal number2)
        {
            decimal answer = number1 * number2;
            return answer;
        }
    }
}
