using System;
using System.Collections.Generic;

namespace Pattern.CommandPattern.CalculatorDemo
{
    public class User
    {
        private Calculator calculator = new Calculator();
        private IList<Command> commands = new List<Command>();
        private int current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine("Redo {0} levels", levels);
            for (int i = 0; i < levels; i++)
                if (current < commands.Count - 1)
                    commands[current++].Execute();
        }

        public void Undo(int levels)
        {
            Console.WriteLine("Undo {0} levels", levels);
            for (int i = 0; i < levels; i++)
                if (current > 0)
                    commands[--current].UnExecute();
        }

        public int Compute(char @operator, int operand)
        {
            Command command = new CalculatorCommand(calculator, @operator, operand);
            var result = command.Execute();

            commands.Add(command);
            current++;

            return result;
        }
    }
}
