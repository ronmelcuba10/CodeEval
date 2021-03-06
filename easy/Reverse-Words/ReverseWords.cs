using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            ShowReversed(line);
        }
    }
    
    static void ShowReversed(string line){
        Console.WriteLine(string.Join(" ", line.Split(' ').Reverse()));
    }
}
