using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZairovAR.Sprint5.Task2.V19.Lib;
namespace Tyuiu.ZairovAR.Sprint5.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Заиров А.Р. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Заиров Артур Ранисович | АСОиУб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
            Console.WriteLine("* Результат сохранить в файл 'OutPutFileTask2.csv' и вывести на консоль.  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");

            int[,] matrix = new int[3, 3] { { 9, 2, 5 },
                                            { 8, 8, 2 },
                                            { 7, 4, 8 } };
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("Успешно создан!");
            Console.ReadKey();
        }
    }
}
