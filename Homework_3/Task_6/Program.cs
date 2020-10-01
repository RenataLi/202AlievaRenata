using System;
using System.Reflection.Metadata.Ecma335;

namespace Task_6
{
    /*
   Дисциплина: "Программирование"
   Группа:      БПИ202
   Студент:     Алиева Рената Эдуардовна
   Задача:      Трехзначным целым числом кодируется номер аудитории в учебном корпусе.
    Старшая цифра обозначают номер этажа, а две младшие –  номер аудитории на этаже.
    Из трех аудиторий определить и вывести на экран ту аудиторию, которая имеет
    минимальный номер внутри этажа. Если таких аудиторий несколько - вывести любую из них. 
  */

    class Program
    {
        public static uint Auditory(uint num1,uint num2,uint num3)
        {
            //получаем две последние цифры для номера внутри этажа
            uint n1 = num1 % 100;
            uint n2 = num2 % 100;
            uint n3 = num3 % 100;
            //сравниваем и находим минимум
            if (n1<=n2)
            {
                if (n1<= n3)
                {
                    return num1;
                }
                else
                {
                    return num3;
                }

            }
            return num2;
        }


        static void Main(string[] args)
        {
            uint number1, number2, number3;
            if (uint.TryParse(Console.ReadLine(),out number1)&& uint.TryParse(Console.ReadLine(), out number2)&& uint.TryParse(Console.ReadLine(), out number3))
            {
                Console.WriteLine(Auditory(number1,number2,number3));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
