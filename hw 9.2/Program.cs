using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 2.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите другое число: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ShowNums(m, n));
            Console.ReadKey();
        }
        static int ShowNums(int m, int n)
        {
            if (n != m)
            {
                if (n > m) return ShowNums(m, n - 1) + n;
                else return ShowNums(m - 1, n) + m;
            }
            else return m;
        }
    }
}
