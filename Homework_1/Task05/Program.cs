using System;
/*

Task05

Дисциплина: "Программирование"

Группа: БПИ202

Студент: Алиева Рената

Дата: 12.09.2020

Задача: Получить от пользователя значения длин двух катетов,
вычислить и вывести на экран значение гипотенузы.


*/

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Первый катет: ");


            while (!double.TryParse(Console.ReadLine(), out x) || x == 0)       //проверяем на корректность введенный катет
            {
                Console.WriteLine("Некорректное значение");
                Console.Write("Новое значение первого катета: ");
            }
            Console.WriteLine("Второй катет: ");

            while (!double.TryParse(Console.ReadLine(), out y) || y == 0)       //проверяем на корректность введенный катет
            {
                Console.WriteLine("Некорректное значение");
                Console.Write("Новое значение второго катета: ");
            }
            double c = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.Write("Полученная гипотенуза: " + c);
        }
    }
}
