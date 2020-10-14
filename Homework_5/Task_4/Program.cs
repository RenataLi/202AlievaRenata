using System;

namespace Task_4
{
    /*
   Дисциплина: "Программирование"
   Группа:      БПИ202
   Студент:     Алиева Рената Эдуардовна
   Задача:      Пользователем с клавиатуры вводится целое число N > 1. 
    В программе сформировать целочисленный массив, содержащий N первых элементов последовательности Фибоначчи: 
    A[0] = 1, A[1] = 1, A[2] = A[0] + A[1], … A[K] = A[K-1] + A[K-2], … 
    Формирование массива организовать при помощи метода. 
    Элементы массива вывести на экран в обратном порядке, методы класса Array не использовать. 

*/
    class Program
    {
        public static void Fibbonachi(int n)
        {
            int[] array = new int[n];
            array[0] = 1;
            array[1] = 1;
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = array[i - 2] + array[i - 1];

            }
            for (int i = array.Length - 1; i > -1; i--)
            {
                Console.Write("{0,4}", array[i]);
            }


        }
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int n) && n > 1)
            {
                Fibbonachi(n);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }

        }
    }
}
