using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1._1
{
    class Program
    {
        //Написать программу,  которая в цикле введет 5 значений и посчитает произведение чисел, которые делятся без остатка на 3 и не делятся без остатка на 5
        //задание 1.1
        static void task1_1() 
        {
            Array Mass = Array.CreateInstance(typeof(double), 5); //в данном массиве будут храниться введенные значения
            double input, output=1; 
            bool Test = false;
            Console.WriteLine("Введите 5 чисел");
            for(int i = 0; i < Mass.Length; i++)
            {
            while (!double.TryParse(Console.ReadLine(), out input)) //цыкл ввода, если пользователь вводит не число то выдаст предупреждение
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
                Mass.SetValue(input, i);
            }
            for (int i = 0; i < Mass.Length; i++) // проходим по массиву введенных чисел и проверяем каждое на соответствие заданным параметрам
            {
                if ((double)Mass.GetValue(i) % 3 == 0 && (double)Mass.GetValue(i) % 5 != 0) { output *= (double)Mass.GetValue(i);
                    Test = true;
                }
            }
            if(Test)Console.WriteLine($"Вывод по заданию 1.1: произведение соответствующих чичел: {output}");
            else Console.WriteLine($"Вывод по заданию 1.1: 0"); // если ниодно число не соответствовало заданным параметрам
        }
        //Одноклеточная амеба каждые 3 часа делится на 2 клетки. Определить, сколько клеток будет через 3, 6, 9, ..., 24 часа, если первоначально была одна амеба.
        //задание1.2
        //задание на геометрическую прогрессию решается циклом а в метод мы передаем период который мы хотим наблюдать
        static void task1_2(int Time) 
        {
            int number = 1, real_time=0;  
            Console.WriteLine($"Вывод по заданию 1.2: в момент времени {real_time} часа имеем {number} амебы");
            while (real_time < Time) 
            {
                real_time += 3;
                number *= 2;
                Console.WriteLine($"в момент времени {real_time} часа имеем {number} амебы");

            }

        }

        static void Main(string[] args)
        {
            task1_1();
            task1_2(24);
            System.Console.ReadKey(true);

        }
    }
}
