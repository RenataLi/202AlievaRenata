using System;
/*
   Дисциплина: "Программирование"
   Задача 7.
   Группа:      БПИ202
   Студент:     Адиева Рената Эдуардовна
   Задача:      Написать программу с использованием двух методов. Первый метод возвращает дробную и целую часть числа. 
   Второй метод возвращает квадрат и корень из числа. В основной программе пользователь вводит дробное число. 
   Программа должна вычислить, если это возможно, значение корня, квадрата числа, выделить целую и дробную часть из числа.
   

*/

namespace Test7
{
    class Program
    {
        public static void PartsOfNumber(double n,out int whole,out double fraction)
        {
            whole = (int)n;
            fraction = n - whole;

        }
        public static void SqrtAndSquare(double n,out double sqrt,out double square)
            
        {
            sqrt = Math.Sqrt(n);
            square = n * n;

        }
        static void Main(string[] args)
        {

            double value;
            double f, n1, n2;
            int w;

            if (double.TryParse(Console.ReadLine(),out value))
            {
                PartsOfNumber(value, out w, out f);
                Console.WriteLine($"Целая часть числа : {w}");
                Console.WriteLine($"Дробная часть числа : {f}");
                SqrtAndSquare(value, out n1, out n2);
                Console.WriteLine($"Корень числа : {n1}");
                Console.WriteLine($"Квадрат числа : {n2}");

            }
            else
            {
                Console.WriteLine("Incorrect input");
            }

        }
    }
}
