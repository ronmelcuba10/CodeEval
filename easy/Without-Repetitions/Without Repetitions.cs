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
            ShowSentence(line);
        }
    }
    
    static void ShowSentence(string line){
        if(line.Length<2)Console.Write(line);
        else {
            for(int i=0; i<line.Length;i++){
                if(i==0) Console.Write(line[i]);
                    else if(!line[i].Equals(line[i-1])) Console.Write(line[i]);
            }
        }
        Console.WriteLine();        
    }
}
