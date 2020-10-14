using System;

namespace Task_2
{
    /*
   Дисциплина: "Программирование"
   Группа:      БПИ202
   Студент:     Алиева Рената Эдуардовна
   Задача:      Пользователем с клавиатуры вводится целое число N > 0.
    В программе сформировать и вывести на экран целочисленный массив из N элементов, 
    элементами которого являются нечетные числа от 1. Заполнение массива нечётными числами организовать при помощи метода.


*/
    class Program
    {
        public static void GetArray(int n)
        {
            int[] array = new int[n];
            int m = 1;
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = m;
                m = m + 2;


            }
            Console.WriteLine(string.Join(",", array));
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                GetArray(n);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
