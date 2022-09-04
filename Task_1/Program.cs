//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

namespace Task_1
{
    internal class Program
    {
        public static double secondNum(int num)
        {
            return char.GetNumericValue(Convert.ToString(num), 1);  // При переводе в Int32 выдавал ASCII
        }
        private static void Main(string[] args)
        {

                
            int num = new Random().Next(100, 999);
            Console.WriteLine(num);
            Console.WriteLine(secondNum(num));

            //Console.WriteLine($"{(num / 10) % 10}"); - Второе решение
            //Console.WriteLine(num);

        }
    }
}