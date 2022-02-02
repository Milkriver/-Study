using System;

namespace functional_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            System.Console.WriteLine("a =  " + a + ", b = " + b);

            int result = a + b;
            System.Console.WriteLine("Сложение, a + b =  " + result);

            result = a * b;
            System.Console.WriteLine("Умножение, a * b =  " + result);

            result = a / b;
            System.Console.WriteLine("Деление, a / b =  " + result + " a и  b - целые числа, деление только нацело");

            double resultDouble = a / b;
            System.Console.WriteLine("Деление, a / b =  " + resultDouble + " все равно что-то не так...");

            double aDouble = 5.5;

            resultDouble = aDouble / b;
            System.Console.WriteLine("Деление, a / b =  " + resultDouble);
            System.Console.WriteLine("cast aDouble " + (int)aDouble);
            System.Console.ReadLine();

        }
    }
}
