using System;
/*
   Дисциплина: "Программирование"
   Задача 4.
   Группа:      БПИ202
   Студент:     Адиева Рената Эдуардовна
   Задача:     Получить от пользователя четырехзначное натуральное число и напечатать его цифры в обратном порядке.

   

*/

namespace Task4
{
    class Program
    {
        public static int AnotherDigits(int n)
        {
            int digit4 = n % 10;
            int digit3 = (n / 10) % 10;
            int digit2 = (n / 100) % 10;
            int digit1 = n / 1000;
            int finalnumber = digit4 * 1000 + digit3 * 100 + digit2 * 10 + digit1;
            return finalnumber;
        }
        static void Main(string[] args)
        {
            int value;
            if (int.TryParse(Console.ReadLine(), out value)&& value>=1000&&value<=9999)
            {
                Console.WriteLine(AnotherDigits(value));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
