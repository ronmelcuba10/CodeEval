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
            ShowBinary(line);
        }
    }
    
    public static void ShowBinary(string line){
        string pattern = @"^(\S+?)?\1";
        Regex r = new Regex(pattern);
        if (Regex.IsMatch(line, pattern)) 
            Console.WriteLine(r.Match(line).Groups[1].Length);
        else Console.WriteLine(line.Length);
    }
}
