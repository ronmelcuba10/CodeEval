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
            Show1s(line);
        }
    }
    
    static void Show1s(string line){
        string bin = Convert.ToString(Int32.Parse(line),2).ToString();
        string[] str = bin.Split('1');
        Console.WriteLine(str.Length-1);
    }
}
