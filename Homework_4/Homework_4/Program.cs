using System;

namespace Homework_4
{
    class Program
    {
        public static bool Validate(ref int a, ref int b, ref int c)
        {
            if (int.TryParse(Console.ReadLine(),out a)&& int.TryParse(Console.ReadLine(), out b)&& int.TryParse(Console.ReadLine(), out c))
            {
                return true;
            }
            return false;
        }
        public static int IsItThree(ref int a,ref int b,ref int c)
        {
            if (a*a+b*b==c*c)
            {
                Console.WriteLine(a, b, c);
            }
        }
        static void Main(string[] args)
        {
            if (Validate(ref a,ref b,ref c))
            {
                for (int a = 1; a < 21; a++)
                {
                    for (int b = 1; b < 21; b++)
                    {
                        for (int c = 1; c < 21; c++)
                        {
                            IsItThree(ref a, ref b, ref c);
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
            
        }
    }
}
