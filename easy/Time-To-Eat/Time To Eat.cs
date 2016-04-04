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
            ShowSortedTime(line);
        }
    }
    
    static void ShowSortedTime(string line){
        string[] timeStamps = line.Split(' ');
        Array.Sort(timeStamps);
        for(int i=timeStamps.Length-1;i>=0;i--)Console.Write(timeStamps[i] + " ");
        Console.WriteLine();
    }
}
