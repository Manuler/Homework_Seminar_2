
//Вывести число без второй цифры

namespace Additional_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string num = (Console.ReadLine());
            string str = string.Empty;
            int i = 0;

            while (i < num.Length)
            {
                if (i != 1) str += num[i];
                i++;
            }
            Console.WriteLine("Число без второй цифры: \n" + str);
                

        }
    }
}