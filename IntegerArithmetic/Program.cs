using System;

namespace IntegerArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = 30 - 10 + 2 * 40; // integer == 100
            integer = -23 / 4; // integer == -5
            integer = 23 % -4;

            int number1 = 30 - 10 + 2 * 40;
            int number2 = 100 - 1;
            bool integerComparison = number1 > number2;

            Console.WriteLine($"Integer: {integer}\n" +
                              $"{number1} is Bigger than {number2}: {integerComparison}");
        }
    }
}
