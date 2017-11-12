using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithEnumsAndSwitchCases
{
    class Program
    {
            public enum MathType
        {
            ADD,
            SUBTRACT,
            DIVIDE,
            MULTIPLY
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please choose 2 numbers.");

            Console.Write("Number1: ");
            var number1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Number2: ");
            var number2 = Convert.ToDecimal(Console.ReadLine());
            bool correct = false;
            do

            {
                Console.WriteLine("Would you like to Add, Subtract, Divide, or Multiply?");
                var mathOperation = Console.ReadLine().ToUpper();

                MathType match;

                var isMatch = Enum.TryParse<MathType>(mathOperation, out match);
                if (!isMatch)
                {
                    Console.WriteLine("I'm sorry that operation is not valid.");
                    correct = false;
                }

                else

                    switch (match)
                    {
                        default:
                            {
                                Console.WriteLine("I'm sorry, that operation is not valid.");
                                correct = false;
                                break;
                            }
                        case MathType.ADD:
                            {

                                var calculator = new Calculator();
                                var addedNumbers = calculator.Add(number1, number2);
                                Console.WriteLine("Your answer is: " + addedNumbers);
                                correct = true;
                                Console.ReadLine();
                                break;

                            }
                        case MathType.SUBTRACT:
                            {
                                var calculator = new Calculator();
                                var subtractedNumbers = calculator.Subtract(number1, number2);
                                Console.WriteLine("Your answer is: " + subtractedNumbers);
                                correct = true;
                                Console.ReadLine();
                                break;
                            }
                        case MathType.MULTIPLY:
                            {
                                var calculator = new Calculator();
                                var multipliedNumbers = calculator.Multiply(number1, number2);
                                Console.WriteLine("Your answer is: " + multipliedNumbers);
                                correct = true;
                                Console.ReadLine();
                                break;
                            }
                        case MathType.DIVIDE:
                            {
                                var calculator = new Calculator();
                                var dividedNumbers = calculator.Divide(number1, number2);
                                Console.WriteLine("Your answer is: " + dividedNumbers);
                                correct = true;
                                Console.ReadLine();
                                break;
                            }

                    }
            } while (correct == false);
        }
    
    }
}
