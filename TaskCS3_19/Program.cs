// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskCS3_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите пятизначное число ");
            int input_number = int.Parse(Console.ReadLine());
            if ((input_number < 10000) || (input_number > 99999))
            {
                Console.WriteLine("Некорректный ввод ");
            }
            else
            {
                // основное тело программы
                if (
                    ((input_number % 10) == ((input_number - input_number % 10000)/10000)) &&
                    (((input_number % 100 - input_number % 10) / 10) == (input_number % 10000 - input_number % 1000) / 1000)
                    )
                { Console.WriteLine("Да"); }
                else { Console.WriteLine("Нет"); }
                //Console.WriteLine((input_number % 100 - input_number % 10) /10 );
                //Console.WriteLine((input_number % 10000 - input_number % 1000) / 1000);
            }

        }
    }
}
