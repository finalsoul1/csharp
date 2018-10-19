using System;


namespace Hw1016_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            i = 0 and j = 0
            i = 1 and j = 1
            i = 2 and j = 2
            */
            for (int i = 0; i < 3; i++)
            {
                int j = i;
                Console.WriteLine("i = {0} and j = {1}", i, j);
            }

            /*
            C# For Loop: Iteration 1
            C# For Loop: Iteration 2
            C# For Loop: Iteration 3
            C# For Loop: Iteration 4
            C# For Loop: Iteration 5
            */

            int ii = 1;
            for (;ii < 6;)
            {
                Console.WriteLine("C# For Loop: Iteration {0}", ii);
                ii++;
            }

        }
    }
}
