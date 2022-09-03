namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string stringNum = Convert.ToString(num);
        
            void ThirdNumber(int num)
            {
                if (num <= 99) Console.WriteLine("Третьего числа нет");
                else
                    while (i < stringNum.Length)
                    {
                        if (i == 2) Console.WriteLine(stringNum[i]);
                        if (i == 3) break;
                        i++;
                    }

            }

            ThirdNumber(num);
        }
    }
}