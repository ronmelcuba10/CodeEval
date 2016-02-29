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
            ShowCharacter(line);
        }
    }
    
    static void ShowCharacter(string line){
        int size = line.Length;
        int i = 0;
        while(i<size){
            int j = 0;
            while(j<size){
                if(i!=j && line[i].Equals(line[j])) break;
                j++;
            }
            if (j==size) break;
            i++;
        }
        Console.WriteLine(line[i]);
    }
    
}
