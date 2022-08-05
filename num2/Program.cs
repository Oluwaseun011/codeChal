using System;

namespace num2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pract = { 7, 10, 3, 11, 34, 2 };
            Game(pract);
        }

        static void Game(int[] asd)
        {
           
            foreach(var i in asd)
            {
                if(i<=6)
                {
                    Console.WriteLine("First");
                }
                else
                {
                    if((i - 5) % 3 == 0 || (i - 5) % 2 == 0)
                    {
                        Console.WriteLine("second");
                    }
                    else
                    {
                        Console.WriteLine("first");
                    }
                }
            }
        }
    }
}
