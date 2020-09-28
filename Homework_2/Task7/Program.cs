using System;
using System.Globalization;
/*
   Дисциплина: "Программирование"
   Задача 6.
   Группа:      БПИ202
   Студент:     Адиева Рената Эдуардовна
   Задача:      Получить от пользователя вещественное значение – бюджет пользователя и целое число – процент бюджета, 
   выделенный на компьютерные игры. Вычислить и вывести на экран сумму в рублях\евро или долларах, 
   выделенную на компьютерные игры. Использовать спецификаторы формата для валют.

   

*/

namespace Task7
{
    class Program
    {
        public static string Money(double a, double b)
        {
            double procent = b / 100;
            double money = a * procent;
            string result = string.Format(new CultureInfo("en-US"), "{0:c}", money);

            return result;
        }
        static void Main(string[] args)
        {
            try
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Money(a, b));


            }
            catch (FormatException)
            {

                Console.WriteLine("Incorrect input");
            }
        }
    }
}
