using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1_Plarium
{
    class Program
    {   //медод для решения первой части 3го задания
        //Найти расположение (индекс) наибольшего числа в массиве. Если таких чисел несколько, найти индекс первого из них.
        static int task3_1(int[] Mass)
        {
            int index = 0;
            for (int i = 0; i < Mass.Length; i++) 
            {
                if (Mass[i] > Mass[index]) index = i;
            }
            return index;
        }
        //медод для решения второй части 3го задания
        //Даны два возрастающих целочисленных массива: x длиной k и y длиной m. Найти количество общих элементов в этих массивах (то есть количество тех целых t, для которых t=x[i]=y[j] для некоторых i и j)
        static int task3_2(int[] Mass, int[] Mass2)
        {
            int counter = 0;
            int t=Mass[0]-1;
            for (int i = 0; i < Mass.Length; i++)
                for (int j = 0; j < Mass2.Length; j++)
                    if (Mass[i] == Mass2[j] && t!=Mass[i] && t != Mass2[j])
                    { 
                        counter++;
                        t = Mass[i];
                    }
                    return counter;
        }
        //медод для решения третей части 3го задания
        /*Даны заданное слово и непустая последовательность слов (одномерный символьный массив): между словами запятые или пробелы, в конце точка. 
         * В словах могут встретиться ошибки – переставлены две соседние буквы, заменена одна буква, пропущена одна буква. 
         * Требуется найти в последовательности слов все слова, из которых могло бы получиться заданное слово в результате одной ошибки. Не использовать строковые функции*/
       
        
        
        static void task3_3(string Mass, string Mass2)
        {
            //string[] Test = " ";
            //int j = 0;
            //for(int i = 0; Mass2[i] != '.'; i++)
            //{
            //    if(Mass2[i]!=' ' || Mass2[i] != ',')
            //    {
            //        Test += Mass2[i];

            //    }
               
            //}

            
        }
        //медод для решения четвертой части 3го задания
        /*Дана целочисленная прямоугольная матрица. Определить:
         *сумму элементов в тех строках, которые содержат хотя бы один отрицательный элемент;
         *номера строк и столбцов всех седловых точек матрицы.
         *Примечание. Матрица А имеет седловую точку Аij, если Аij является минимальным элементом в i-й строке и максимальным в j-м столбце*/
        static void task3_4(int[,] Mass)
        {
            bool Test = true;
            int min = 0, max=0, summ=0;            
            int stroc = Mass.GetLength(0);
            int stolb = Mass.GetLength(1);
            for (int i=0; i < stroc; i++) {
                summ = 0; Test = false;
                for (int j = 0; j < stolb; j++)
                {
                    summ += Mass[i, j];
                    if(Mass[i,j]<0) Test = true;
                }
                if (Test) Console.WriteLine($"Сумма элементов в строке {i} равна {summ}");
            }


            for (int i = 0; i < stroc; i++)
            {
                Test = true;
                min = i; max = 0;
                for (int j = 0; j < stolb; j++)
                {
                    if (Mass[i, j] < Mass[min,max]) {      
                        min = i; max = j;
                    }
                }

                for(int k = 0; k < stroc; k++)
                {
                    if (Mass[min, max] < Mass[k, max]) Test = false;
                }
                if(Test) Console.WriteLine($"Элемент:{Mass[min,max]} с координатами {min} и {max} следовой точкой");
            }
        }

        static void Main(string[] args)
        {
            int[] Array_task1 = {5,3,6,3,1,6,2};
            Console.WriteLine($"Вывод по заданию 1: индекс наибольшего элемента в массиве: {task3_1(Array_task1)}");
            int[] x = { 0,3,3,3,5,7,8,8,9,9,34 };
            int[] y = { -1,3,3,7,9,9,9,12,13,34,34,34 };
            Console.WriteLine($"Вывод по заданию 2: Количество одинаковых эллементов: {task3_2(x,y)}");
            string Slovo = "Slovo";
            string Text = "Sloovo Slooro Soco klovo slovo SLOVO Slovo Skovo,Solvo.";
            Console.WriteLine($"Вывод по заданию 3:");
            task3_3(Slovo,Text);
            int[,] Mass = { {-3,9,2,1 },{7,8,5,6 },{4,7,3,5 },{5,6,1,-7 } };
            Console.WriteLine($"Вывод по заданию 4:");
            task3_4(Mass);
            System.Console.ReadKey(true);
        }
    }
}
