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


            Console.WriteLine("Домашнее задание 4. Квадратное уравнение");
            Console.WriteLine("Введите число a :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c :");
            int num_3 = int.Parse(Console.ReadLine());
            double discrim = num2 * num2 - 4 * num1 * num_3;
            
            if (discrim < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else if (discrim == 0)
            {
                double x1 = -1 * num2 / 2 * num1;
                Console.WriteLine(x1);

            }
            else
            {
                double x2 = (-num2 + Math.Pow(discrim, 0.5)) / (2 * num1);
                double x3 = (-num2 - Math.Pow(discrim, 0.5)) / (2 * num1);
                Console.WriteLine("Корень 1 : " + x2 + "\n" + "Корень 2 : " + x3);

            }
        }
    }
}
