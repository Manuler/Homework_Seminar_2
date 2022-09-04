/* Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
*/

namespace Task_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру, обозначающую день недели");
            string dayNum = Console.ReadLine();
            if (dayNum == "6" ^ dayNum == "7") Console.WriteLine("Это выходной день");
            else if (dayNum == "1" ^ dayNum == "2" ^ dayNum == "3" ^ dayNum == "4" ^ dayNum == "5" ^ dayNum == "6") 
                Console.WriteLine("Это рабочий день");
            else Console.Write("Это число не соответствует дням недели");
        }
    }
}