using System;
using System.Linq;

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите любое положительное число и нажмите клавишу Enter: ");
            string userAnswer = Console.ReadLine();
            int userAnswerNumber = Convert.ToInt32(userAnswer);
            Console.WriteLine("Факториал " + userAnswer + " равен " + Factorial(userAnswerNumber));
        }
        public static int Factorial(int n)
        {
            return Enumerable
                .Range(1, n)
                .Aggregate(1, (x, y) => x *= y);
        }

    }
}
