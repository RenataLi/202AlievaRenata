using System;
/*
   Дисциплина: "Программирование"
   Задача 1.
   Группа:      БПИ202
   Студент:     Адиева Рената Эдуардовна
   Задача:      Ввести значение x и вывести значение полинома: F(x) = 12x4 + 9x3 - 3x2 + 2x – 4. 
   Не применять возведение в степень. Использовать минимальное количество операций умножения.

   

*/

namespace Homework_2
{
    class Program
    {
        public static int Function(int n)
        {
            return 12*n*n*n*n + 9*n*n*n - 3*n*n + 2*n -4;
        }
        static void Main(string[] args)
        {
            int value;
            if (int.TryParse(Console.ReadLine(),out value))
            {
                Console.WriteLine(Function(value));

            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
