using System.IO;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 13; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    System.Console.Write("{0,4:d}", i*j);
                }
                System.Console.WriteLine();
            }
        }
    }
}
