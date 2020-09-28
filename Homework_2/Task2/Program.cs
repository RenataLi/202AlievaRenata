using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Net;
/*
   Дисциплина: "Программирование"
   Задача 2.
   Группа:      БПИ202
   Студент:     Адиева Рената Эдуардовна
   Задача:      Ввести натуральное трехзначное число Р. Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р.

   

*/

namespace Task2
{

    class Program
    {
        public static int FindTheBiggestNumber(int n)
        {
            int a = n % 10;
            int b = (n / 10) % 10;
            int c = (n / 100);
            int sum = a + b + c;
            int max = Math.Max(Math.Max(a, b), c);
            int min = Math.Min(Math.Min(a, b), c);
            int middle = sum - max - min;
            int finalnumber = max * 100 + middle * 10 + min;
            return finalnumber;
            

        }
        static void Main(string[] args)
        {
            int P;
            if (int.TryParse(Console.ReadLine(),out P) && P>= 100 && P <= 1000)
            {
                Console.WriteLine(FindTheBiggestNumber(P));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
