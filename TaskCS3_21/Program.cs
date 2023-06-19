// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве

using System;

namespace TaskCS3_21
{
    class TaskCS3_21
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую координату точки A: ");
            int input_xA = int.Parse(Console.ReadLine());
            Console.Write("Введите вторую координату точки A: ");
            int input_yA = int.Parse(Console.ReadLine());
            Console.Write("Введите третью координату точки A: ");
            int input_zA = int.Parse(Console.ReadLine());
            Console.Write("Введите первую координату точки B: ");
            int input_xB = int.Parse(Console.ReadLine());
            Console.Write("Введите вторую координату точки B: ");
            int input_yB = int.Parse(Console.ReadLine());
            Console.Write("Введите третью координату точки B: ");
            int input_zB = int.Parse(Console.ReadLine());
            Console.Write("Расстояние между точками A и B  в пространстве равно: ");
            Console.WriteLine(Math.Sqrt((input_xA - input_xB) * (input_xA - input_xB) + (input_yA - input_yB) * (input_yA - input_yB) +
                (input_zA - input_zB) * (input_zA - input_zB)));
        }
    }
}
