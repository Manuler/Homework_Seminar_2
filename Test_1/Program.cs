namespace Test_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            void ThirdNumber(int arrg)
            {
                if (num <= 99) Console.WriteLine("Третьего числа нет");
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