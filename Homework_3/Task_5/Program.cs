using System;

namespace Task_5
{
    /*
  Дисциплина: "Программирование"
  Группа:      БПИ202
  Студент:     Алиева Рената Эдуардовна
  Задача:      ТНаписать метод, вычисляющий значение функции G=F(X)
 */
    class Program
    {
        private static double G(double x)
        {
            double res = 0;
            //вычисляем значения ссылаясь на систему уравнений
            if (x <= 0.5)
            {
                 res = Math.Sin(Math.PI/2);

            }
            if (x>0.5)
            {
                 res = Math.Sin(Math.PI * (x - 1) / 2);
            }
            return res;
        }
        static void Main(string[] args)
        {
            double x, g;
            if (double.TryParse(Console.ReadLine(), out x))
            {
                g = G(x);
                Console.WriteLine(g.ToString());
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
