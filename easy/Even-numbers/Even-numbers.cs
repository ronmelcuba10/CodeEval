using System;
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
            // do something with line
            OddNumber(line);
        }
    }
    
    static void OddNumber(string line){
        Console.WriteLine((Convert.ToInt32(line)+1)%2);
    }
}
