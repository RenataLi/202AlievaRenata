using System;
/*

Task02

Дисциплина: "Программирование"

Группа: БПИ202

Студент: Алиева Рената

Дата: 11.09.2020

Задача: 

В текстовом режиме выведите в консольное окно изображение вашей фамилии, 
составленное из выбранных вами символов ('*', 'x', проч.). 


*/
namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    *         *     *    * *****  ****      *       ");
            Console.WriteLine("   * *       * *    *   ** *      *   *    * *      ");
            Console.WriteLine("  * * *     *   *   *  * * *****  ***     * * *     ");
            Console.WriteLine(" *     *   *     *  * *  * *      *   *  *     *    ");
            Console.WriteLine("*       * *       * *    * *****  ****  *       *   ");

            Console.WriteLine("Для выхода нажмите Enter");
            Console.ReadLine();
        }
    }
}
