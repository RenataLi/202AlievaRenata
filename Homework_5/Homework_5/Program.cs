using System;
using System.Linq;

namespace Homework_5
{
    /*
  Дисциплина: "Программирование"
  Группа:      БПИ202
  Студент:     Алиева Рената Эдуардовна
  Задача:      Пользователем с клавиатуры вводится целое число N > 0. 
    В программе сформировать и вывести на экран целочисленный массив из N элементов. 
    Значениями элементов являются степени числа 2 от нулевой до N-1 (1, 2, … 2N-1). 
    Заполнение массива степенями числа 2 организовать при помощи метода.



*/
    class Program
    {
       
        public static void GetArray(int n)
        {
            
            int[] arr = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                arr[i] = (int)Math.Pow(2,i);
                

                
            }
            
            
            Console.WriteLine(string.Join(",", arr));
            
            
        }
        static void Main(string[] args)
        {
            
            if (int.TryParse(Console.ReadLine(),out int n))
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
