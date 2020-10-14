using System;

namespace Task_1
{
    /*Дисциплина: "Программирование"
   Группа:      БПИ202
   Студент:     Алиева Рената Эдуардовна
   Задача:      Определить все тройки попарно различных целых чисел 𝑎,𝑏,𝑐 из интервала[1;20], для которых верно 𝑎^2+𝑏^2=𝑐^2.
    
     */

    class Program
    {


        public static void Triple(ref int a, ref int b, ref int c)
        {
            if (a * a + b * b == c * c)
            {
                Console.WriteLine($"{a},{b},{c}");

            }

        }
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;


            for (a = 1; a < 21; a++)
            {
                for (b = 1; b < 21; b++)
                {
                    for (c = 1; c < 21; c++)
                    {


                        Triple(ref a, ref b, ref c);


                    }
                }
            }




        }

    }
}
