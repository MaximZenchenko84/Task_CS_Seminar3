// Напишите программу, которая принимает на вход число (N) b выдает таблицу кубов чисел от 1 до N

using System;

namespace TaskCS3_23
{
    class TaskCS3_23
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N = ");
            int N = int.Parse(Console.ReadLine());
            int current_n = 1;
            if (current_n > N) { Console.WriteLine("Некорректный ввод "); }
            else
            {
                Console.Write("Кубы чисел до "); Console.Write(N); Console.WriteLine(": ");
                do
                {
                    Console.WriteLine(Math.Pow(current_n,3));
                    current_n++;
                }
                while (current_n <= N);
            }
        }
    }
}
