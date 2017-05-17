using System;

namespace Pattern.CommandPattern.CalculatorDemo
{
    public class CalculatorCommand : Command
    {
        private char @operator;
        private int operand;
        private Calculator calculator;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this.calculator = calculator;
            this.@operator = @operator;
            this.operand = operand;
        }

        public override int Execute()
        {
            return calculator.Operation(@operator, operand);
        }

        public override int UnExecute()
        {
            return calculator.Operation(Undo(@operator), operand);
        }

        private char Undo(char @operator)
        {
            char undo = ' ';

            switch (@operator)
            {
                case '+':
                    undo = '-';
                    break;
                case '-':
                    undo = '+';
                    break;
                case '*':
                    undo = '/';
                    break;
                case '/':
                    undo = '*';
                    break;
                default:
                    throw new Exception("Invalid operator");
            }

            return undo;
        }
    }
}
