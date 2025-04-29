using System;
namespace Loop22
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            for (a = 1; a <= 7; a++)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write(a + "");
                }
                Console.WriteLine();
            }
            for (a = 1; a <= 7; a++)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write(b + "");
                }
                Console.WriteLine();
            }
        }

    }
}