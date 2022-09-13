using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooMach_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1.Приветствие");
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Здравствуйте," + name);



            Console.WriteLine("Задача 2. Деление");
            Console.WriteLine("Введите 1 число");
            string number = Console.ReadLine();
            int a = Convert.ToInt32(number);
            Console.WriteLine("Введите 2 число");
            string number1 = Console.ReadLine();
            int b = Convert.ToInt32(number1);
            if (b != 0)
            {
                int result = a / b;
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine("Деление на 0!");
            }



            Console.WriteLine("Домашнее задание 3" + " Вывод последующей буквы");

            Console.WriteLine("Введите букву");
            char let;
            let = char.Parse(Console.ReadLine());
            int num = Convert.ToInt32(let);
            int n = num + 1;
            char next = (char)n;
            Console.WriteLine(next);



            Console.WriteLine(" Задача 4. Решение квадратного уравнения");
            Console.WriteLine("Введите число a :");
            int num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b :");
            int num_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c :");
            int num_3 = int.Parse(Console.ReadLine());
            double discrim = Math.Pow(num_2, 2) - 4 * num_1 * num_3;
            double root_1 = (num_2 * -1 + Math.Sqrt(discrim)) / 2 * num_1;
            double root_2 = (num_2 * -1 - Math.Sqrt(discrim)) / 2 * num_1;
            Console.WriteLine("Корень 1 : " + root_1);
            Console.WriteLine("корень 2:" + root_2);
        }
    }
}
