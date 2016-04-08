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
            ShowDifference(line);
        }
    }
    
    static void ShowDifference(string line){
            string[] timesStr = line.Split(' ');
            TimeSpan duration = DateTime.Parse(timesStr[1]).
                                        Subtract(DateTime.Parse(timesStr[0]));
            Console.WriteLine(duration.Duration());
        }
}
