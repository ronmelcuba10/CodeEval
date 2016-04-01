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
            ShowWriter(line);
        }
    }
    
    static void ShowWriter(string line){
        int pos = line.IndexOf('|');
        string str =line.Substring(0,pos);
        string[] nums = line.Substring(pos+1).Trim().Split(' ');
        foreach(string num in nums){
            Console.Write(str[Convert.ToInt32(num)-1]);
        }
        Console.WriteLine();
    }
}
