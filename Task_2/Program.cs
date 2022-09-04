//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

namespace Task_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            void ThirdNumber(int args)
            {
                if (num <= 99) Console.WriteLine("Третьей цифры нет");
                else
                {
                    while (num > 999)
                    {
                        num = num / 10;
                    }
                    Console.WriteLine(num % 10);
                }
            }

            ThirdNumber(num);
        }
    }
}