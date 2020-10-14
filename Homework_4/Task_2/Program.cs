using System;
using System.Diagnostics.CodeAnalysis;

namespace Task_2
{
    /*Дисциплина: "Программирование"
  Группа:      БПИ202
  Студент:     Алиева Рената Эдуардовна
  Задача:      Пользователь последовательно вводит целые числа. Для хранения полученных чисел в программе используется одна переменная. 
    Окончание ввода чисел определяется либо желанием пользователя, либо когда сумма уже введённых отрицательных чисел становится меньше -1000. 
    Определить и вывести на экран среднее арифметическое отрицательных чисел.


    */
    class Program
    {
        public static bool Validate(ref int  a)
        {
            if (int.TryParse(Console.ReadLine(),out a))
            {
                return true;
            }
            return false;
        }
        public static void GetAverage(int sum,int number,int sum1,int count)
        {
            string s = "";
            while (true)
            {
                Console.WriteLine("Enter the number");
                if (Validate(ref number))
                {
                    s += number.ToString();
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] < 0)
                        {
                            sum1 += s[i];
                        }
                        sum += s[i];
                        count += 1;
                        
                        

                    }
                    if (sum1 < -1000)
                    {
                        Console.WriteLine("The sum of negative digits is < -1000");
                        Console.WriteLine("Bye");
                        break;
                    }
                    Console.WriteLine("If you want to exit please write 'Y'");
                    Console.WriteLine("If no,please write something");

                    string answer = Console.ReadLine();
                    if (answer != "Y")
                    {
                        continue;
                    }
                    if (answer == "Y")
                    {
                        Console.WriteLine("Average: " + sum / count);
                        Console.WriteLine("Bye");
                        break;
                    }



                }
            }
        }
        static void Main(string[] args)
        {
            
            int number = 0;
            int sum1 = 0;
            int sum = 0;
            int count = 0;
            GetAverage(sum, number, sum1, count);
            
        }
    }
}
