using System;
/*
   Дисциплина: "Программирование"
   Задача 3.
   Группа:      БПИ202
   Студент:     Адиева Рената Эдуардовна
   Задача:      Введя значения коэффициентов А, В, С, вычислить корни квадратного уравнения. 
   Учесть (как хотите) возможность появления комплексных корней. Оператор if не применять.

   

*/

namespace Task3
{
    class Program
    {
        public static void FindTheRoots(int a, int b, int c, out double x1, out double x2)
        {
            int D = b * b - 4 * a * c;
            x1 = -b - Math.Sqrt(Math.Abs(D)) / 2 * a;
            x2 = -b + Math.Sqrt(Math.Abs(D)) / 2 * a;

        }

        static void Main(string[] args)
        {
            
            double x1;
            double x2;
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                FindTheRoots(a, b, c, out x1, out x2);
                Console.WriteLine($"Первый корень: {x1} ");
                Console.WriteLine($"Второй корень: {x2} ");

            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input");

              
            }
       
        }
    }
}
