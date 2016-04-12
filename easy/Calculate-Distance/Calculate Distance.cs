using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
            ShowDistance(line);
        }
    }
    
    static void ShowDistance(string line){
        MatchCollection mc = Regex.Matches(line, @"[-]?\d+");
        int x1 = Convert.ToInt32(mc[0].Value);
        int y1 = Convert.ToInt32(mc[1].Value);
        int x2 = Convert.ToInt32(mc[2].Value);
        int y2 = Convert.ToInt32(mc[3].Value);
        Console.WriteLine(Math.Sqrt((Math.Pow((y1-y2),2) + Math.Pow((x1-x2),2))));
    }
}
