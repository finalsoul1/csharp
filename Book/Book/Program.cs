#define SOUNDCARD
using System;
using System.Diagnostics;

namespace Book
{
    class Test
    {
        [Conditional ("SOUNDCARD")]
        static void print()
        {
            Console.WriteLine("도레미...");
        }
        static void Main()
        {
            print();
        }
    }
}
