using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1._2
{
    class Program
    { //задание 2.1
        /*В некоторой стране используются денежные купюры достоинством  в 1, 2, 4, 8, 16, 32 и 64. Дано натуральное число п.
     * Как наименьшим количеством таких денежных купюр можно выплатить сумму п (указать количество каждой из используемых для выплаты купюр)?
     * Предполагается, что имеется достаточно большое количество купюр всех достоинств*/
         static void task2_1()
        {
            int input, nominal=64, output;
            Console.WriteLine("Введите числo");
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
            Console.WriteLine($"Вывод по заданию 2.1:");
            while (input > 0)
            {
                output = input / nominal;
                Console.WriteLine($"купюр номиналом {nominal} небходмо {output} штук");
                input %= nominal;
                nominal /= 2;
            }
        }
        //задание 2.2
        /*Дано натуральное число. Верно ли, что цифра а встречается в нем более k раз?*/
        static void task2_2()
        {
            int input, k, output,a;
            Console.WriteLine("Введите проверяемое числo");
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
            
            Console.WriteLine("Введите числo a");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
            
            Console.WriteLine("Введите числo k");
            while (!int.TryParse(Console.ReadLine(), out k))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }

            while (input > 0)
            {
                output = input % 10;
                if (output == a) k--;
                input /= 10;
            }
            if (k < 0) Console.WriteLine($"утверждение истино");
            else Console.WriteLine($"утверждение ложно");

        }
        //задание 2.3
        /*Дано натуральное число. Определить, верно ли, что сумма его цифр больше т, 
         * а само число заканчивается на y?*/
        static void task2_3()
        {
            int input, t, output=0, y;
            Console.WriteLine("Введите проверяемое числo");
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }

            Console.WriteLine("Введите числo t");
            while (!int.TryParse(Console.ReadLine(), out t))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }

            Console.WriteLine("Введите числo y");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }

            if (input % 10 == y) {
                while (input > 0)
                {

                    output += input % 10;
                    input /= 10;
                } 
                if(output>t) Console.WriteLine($"утверждение истино");
                else Console.WriteLine($"утверждение ложно");
            }
            else Console.WriteLine($"утверждение ложно");
        }
        //задание 2.4
        /*Дано натуральное число, в котором все цифры различны.
         * Определить, какая цифра расположена в нем левее: максимальная или минимальная. */
        static void task2_4()
        {
            int input, min=9,max=0, output;
            bool Test = true;//если истина то максимальное левее, иначе минимальная
            Console.WriteLine("Введите проверяемое числo");
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }

            while (input > 0)
            {
                output = input % 10;
                if (output > max) { max = output;
                    Test = true;
                }
                if (output < min) { min = output;
                    Test = false;
                }
                input /= 10;
            }
            if(Test) Console.WriteLine($"максимальная цифра левее");
            else Console.WriteLine($"минимальная цифра левее");
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"старт задания 2.1");
            task2_1();
            Console.WriteLine($"старт задания 2.2");
            task2_2();
            Console.WriteLine($"старт задания 2.3");
            task2_3();
            Console.WriteLine($"старт задания 2.4");
            task2_4();
            System.Console.ReadKey(true);

        }
    }
}
