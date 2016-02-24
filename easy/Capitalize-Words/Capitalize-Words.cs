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
            Capitalize(line);
        }
    }
    
    public static void Capitalize(string line){
        string[] words = line.Split(' ');
        string result = "";
        for(int i=0;i<words.Length;i++){
            result = result + words[i].Substring(0,1).ToUpper() + words[i].Substring(1,words[i].Length-1) + " ";
            
        }
        Console.WriteLine(result);
    }
}
