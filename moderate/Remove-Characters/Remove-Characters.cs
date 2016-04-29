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
            ShowScrubbedSentence(line);
        }
    }
    
    static void ShowScrubbedSentence(string line){
        string[] chars = line.Split(',');
        chars[1] = chars[1].Trim();
        int index = 0;
        while (index < chars[1].Length){
            chars[0] = chars[0].Replace(chars[1][index].ToString(),"");
        	index++;
        }
        Console.WriteLine(chars[0]);
    }
}
