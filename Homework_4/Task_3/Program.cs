using System;
using System.Security.Cryptography.X509Certificates;

namespace Task_3
{
    /*Дисциплина: "Программирование"
  Группа:      БПИ202
  Студент:     Алиева Рената Эдуардовна
  Задача:      Протабулировать функцию 𝑦 на заданном диапазоне, с заданным шагом изменения аргумента, значения 𝑎,𝑏,𝑐 вводит пользователь.


    */
    class Program
    {
        public static bool Validate(ref double a,ref double b,ref double c)
        {
            if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && double.TryParse(Console.ReadLine(), out c))
            {
                return true;
            }
            return false;
        }
        public static void Function(ref double a,ref double b,ref double c)
        {
            for (double i = 1;  i < 3; i += 0.05)
            {
                if (i<1.2)
                {
                    Console.WriteLine(a*i*i+b*i+c);
                }
                if (i==1.2)
                {
                    Console.WriteLine(a/i+Math.Sqrt(i*i+1));
                }
                if (i>1.2)
                {
                    Console.WriteLine(a+b*i/Math.Sqrt(i*i+1));
                }
            }
        }
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;

            if (Validate(ref a,ref b,ref c))
            {
                Function(ref a, ref b, ref c);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
