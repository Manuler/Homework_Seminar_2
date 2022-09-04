//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

namespace Task_1
{
    internal class Program

    {
        private static void Main(string[] args)
        {
            void second_num()
            {
                int num = new Random().Next(100, 999);
                Console.WriteLine($"{(num / 10) % 10}");
                Console.WriteLine(num);
            }

            second_num();
        }
    }
}