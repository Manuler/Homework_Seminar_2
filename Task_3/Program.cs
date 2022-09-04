/* Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
*/

using System;

namespace Task_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру, обозначающую день недели");
            int dayNum = int.Parse(Console.ReadLine());
            if (dayNum <= 0 || dayNum > 7) Console.WriteLine("Это число не соответствует дням недели");
            if (dayNum == 6 || dayNum == 7) Console.WriteLine("Это выходной день");
            if (dayNum > 0 && dayNum < 6) Console.WriteLine("Это рабочий день");

        }
    }
}