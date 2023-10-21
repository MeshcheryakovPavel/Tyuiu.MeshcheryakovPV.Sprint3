using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MeshcheryakovPV.Sprint3.Task3.V5.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint3.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Мещеряков П.В. | ИИПБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: АЛГОРИТМЫ ЦИКЛИЧЕСКОЙ СТРУКТУРЫ                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                             *");
            Console.WriteLine("* Выполнил Мещеряков П.В. | ИИПб-23-2                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "fifa al fall";
            char replaceable = 'a';
            char replacement = '*';

            Console.WriteLine("Строка = " + value);
            Console.WriteLine("Заменяемый символ = " + replaceable);
            Console.WriteLine("Заменяющий символ = " + replacement);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Новая строка = " + ds.ReplaceCharInString(value, replaceable, replacement));

            Console.ReadKey();
        }
    }
}
        