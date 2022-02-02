using System;

namespace FiltredArray
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите любой ряд чисел через пробел и нажмите клавишу Enter: ");
            var userAnswer = Console.ReadLine();
            var oddNumbersSum = 0;
            var evenNumberMultiply = 1;
            var arr = userAnswer.Split(" ");
            Console.WriteLine("Массив введен, элеметнов:" + arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbersSum += int.Parse(arr[i]);
                } else { 
                    evenNumberMultiply *= int.Parse(arr[i]);
                }
              
            }

            
            Console.WriteLine("Сумма элементов c нечетными индексами: " + oddNumbersSum);
            Console.WriteLine("Произведение элементов c четными индексами: " + evenNumberMultiply);

            Console.ReadLine();
        }
    }
}
