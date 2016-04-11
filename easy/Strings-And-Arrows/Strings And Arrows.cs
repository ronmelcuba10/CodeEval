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
            ShowArrowsAmount(line);
        }
    }
    
    static void ShowArrowsAmount(string line){
        int counter = 0;
        for(int i=0;i<line.Length-4;i++){
            if((line[i].Equals('>') || line[i].Equals('<')) &&
                IsArrow(line,i)) counter++;
        }
        Console.WriteLine(counter);
    }
        
    static bool IsArrow(string line, int index){
        if(line.Substring(index,5).Equals(">>-->") || 
           line.Substring(index,5).Equals("<--<<"))return true;
        return false;
    }
}
