using System;
/*
   Дисциплина: "Программирование"
   Задача 5.
   Группа:      БПИ202
   Студент:     Адиева Рената Эдуардовна
   Задача:      Получить от пользователя три вещественных числа и проверить для них неравенство треугольника. 
   Оператор if не применять. Точность вывода три знака после запятой.
   

*/


namespace Task5
{
    class Program
    {
        // Метод для проверки неравенства.
        public static bool IsitTriangle(double a,double b,double c)
        {
            while (a < b+c && b < a+c && c < a + b)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            
            
            try
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(IsitTriangle(a, b, c));

            }
            catch (FormatException)
            {

                Console.WriteLine("Incorrect input");
            }  
 
        }
    }
}
