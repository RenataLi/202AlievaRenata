using System;

namespace Task_4
{
    /*
  Дисциплина: "Программирование"
  Группа:      БПИ202
  Студент:     Алиева Рената Эдуардовна
  Задача:      Написать метод, вычисляющий значение функции G=F(X,Y) 𝐺=(𝑋+sin⁡(𝑌),𝑋<𝑌 и 𝑋>0 ;𝑌−cos⁡(𝑋),𝑋>𝑌 и 𝑋<0 ;0.5∙𝑋∙𝑌, в остальных случаях)┤
 */
    class Program
    {
        static double G(double x,double y)
        { // Вычисляем значение ,ссылаясь на систему уравнений.
            if ((x<y) && (x>0))
            {
                return x + Math.Sin(y);

            }
            else if ((x>y) && (x<0))
            {
                return y - Math.Cos(x);
            }
            else
            {
                return 0.5 * x * y;
            }
        }
        static void Main(string[] args)
        {
            double x, y, g;
            if (double.TryParse(Console.ReadLine(),out x)&& double.TryParse(Console.ReadLine(), out y))
            {
                g = G(x, y);
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
