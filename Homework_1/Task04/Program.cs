using System;
/*

Task04

Дисциплина: "Программирование"

Группа: БПИ202

Студент: Алиева Рената

Дата: 11.09.2020

Задача: 

Получить от пользователя значения напряжения U и сопротивления R, 
вычислить силу тока  I = U/R и потребляемую мощность  P = U2/R электрической цепи.


*/

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            double U, R;       //создаем значения напряжения U и сопротивления R
            Console.WriteLine("Значение напряжения: ");


            while (!double.TryParse(Console.ReadLine(), out U))        //проверяем на корректность введенное напряжение
            {
                Console.WriteLine("Некорректное значение");
                Console.Write("Новое значение напряжения: ");
            }
            Console.WriteLine("Введите значение сопротивления: ");

            //проверяем на корректность сопротивление и исключаем случай когда R = 0
            while (!double.TryParse(Console.ReadLine(), out R) || (R == 0))
            {
                Console.WriteLine("Некорректное значение");
                Console.Write("Новое значение сопротивления: ");
            }


            double I = U / R;       //считаем значение силы тока
            double P = Math.Pow(U, 2) / R;         //считаем значение мощности
            //вывод значения силы тока и мощности
            Console.WriteLine("Значение силы тока: " + I.ToString("F"));
            Console.WriteLine("Значение мощности: " + P.ToString("F"));
        }
    }
}
