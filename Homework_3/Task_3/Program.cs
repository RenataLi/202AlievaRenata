using System;
using System.Security.Cryptography.X509Certificates;

namespace Task_3
{
    /*
  Дисциплина: "Программирование"
  Группа:      БПИ202
  Студент:     Алиева Рената Эдуардовна
  Задача:      Написать метод, вычисляющий логическое значение функции G=F(X,Y). 
    Результат равен true, если точка с координатами (X,Y) попадает в фигуру G,
    и результат равен false, если точка с координатами (X,Y) не попадает в фигуру G. 
    Фигура G - сектор круга радиусом R=2 в диапазоне углов -90<= fi <=45.

 */
    class Program
    {
        public static bool IfContains(double x, double y,int r)
        {
            // Находим значение угла ,тангенс которого равен отношению координат.
            double atan = Math.Atan2(y, x);
            return x * x + y * y <= r*r  && -0.5 * Math.PI <= atan && atan <= 0.25 * Math.PI;
        }
        static void Main(string[] args)
        {
            int r = 2;
            double x, y;
            

            if (double.TryParse(Console.ReadLine(),out x) && double.TryParse(Console.ReadLine(), out y) && IfContains(x,y,r))
            {
                Console.WriteLine("True");
                

            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
