using System;

namespace Task_3
{
    /*
   Дисциплина: "Программирование"
   Группа:      БПИ202
   Студент:     Алиева Рената Эдуардовна
   Задача:      Пользователем с клавиатуры вводятся целые числа N > 1, A и D. 
    В программе сформировать и вывести на экран целочисленный массив из N элементов. 
    Элементы вычисляются: A[0] = A, A[1] = A + D, A[2] = A + 2*D, … A[N-1] = A + (N-1)*D. 
    Формирование массива организовать при помощи метода.

*/

    class Program
    {
        public static void GetArray(int n, int a, int d)
        {
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = a + d * i;
                Console.Write("{0,4}", array[i]);

            }

        }
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int n) && n > 1 && int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int d))
            {
                GetArray(n, a, d);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
