﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZairovAR.Sprint5.Task1.V10.Lib;
namespace Tyuiu.ZairovAR.Sprint5.Task1.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            Console.Title = "Спринт #5 | Выполнил: Заиров А.Р. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Заиров Артур Ранисович | АСОиУб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дана функция. Вычислить её значения на диапазоне [-5;5] с шагом 1.      *");
            Console.WriteLine("* Результат сохранить в текстовый файл 'OutPutFileTask0.txt' и вывести    *");
            Console.WriteLine("* на консоль в таблицу. Значения округлить до двух знаков после запятой.  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Начало цикла: {startValue}");
            Console.WriteLine($"Конец цикла: {stopValue}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("Успешно создан!");
            Console.ReadKey();
        }
    }
}
