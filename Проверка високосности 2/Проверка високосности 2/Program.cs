using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Проверка_на_високосность
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 4 == 0)
            {
                if ((num % 100 == 0) && (num % 400 != 0))
                    Console.WriteLine("Не високосный");
                else
                    Console.WriteLine("Високосный");
            }
            else
                Console.WriteLine("Не високосный");
            Console.ReadLine();
        }
    }
}