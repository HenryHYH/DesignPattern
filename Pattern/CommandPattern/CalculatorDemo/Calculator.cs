using System;

namespace Pattern.CommandPattern.CalculatorDemo
{
    public class Calculator
    {
        private int total = 0;

        public int Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    total += operand;
                    break;
                case '-':
                    total -= operand;
                    break;
                case '*':
                    total *= operand;
                    break;
                case '/':
                    total /= operand;
                    break;
                default:
                    throw new Exception("Invalid operator");
            }

            Console.WriteLine("Total = {0}(following {1} {2})", total, @operator, operand);

            return total;
        }
    }
}
