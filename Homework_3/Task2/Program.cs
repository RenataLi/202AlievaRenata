using System;
using System.Diagnostics;
using System.Linq;

namespace Task2
{
    /*
  Дисциплина: "Программирование"
  Группа:      БПИ202
  Студент:     Алиева Рената Эдуардовна
  Задача:      Написать метод, преобразующий число переданное в качестве параметра в число, 
  записанное теми же цифрами, но идущими в обратном порядке. 
  Например, 1024 - > 4201, 120 -> 21

 */
    class Program
    {
        public static string ReverseToString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr); // Переворачиваем преобразованную строку.
            return new string(arr);
        }
        static void Main(string[] args)
        {
            
            int n;

            if (int.TryParse(Console.ReadLine(),out n))
            {
                string str = Convert.ToString(n);
                 
                Console.WriteLine(ReverseToString(str));

            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
            
            
            

        }
    }
}
