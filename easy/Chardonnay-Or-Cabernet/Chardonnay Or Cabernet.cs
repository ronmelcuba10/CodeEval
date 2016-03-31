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
            ShowWine(line);
        }
    }
    
    static void ShowWine(string line){
        int pos = line.IndexOf('|');
        string phrase = line.Substring(pos+1).Trim();
        string[] wines = line.Substring(0,pos).Split(' ');
        string result = "";
        foreach(string wine in wines){
            int i = 0;
            string wineTemp = wine;
            while(i<phrase.Length){
                int tempos = wineTemp.IndexOf(phrase[i]);
                if (tempos>=0) wineTemp = wineTemp.Remove(tempos, 1);       
                else break;
                i++;
            }
            if(wine.Length - phrase.Length == wineTemp.Length)result += wine + " ";
        }
        result = result.Trim();
        if(result.Length>0)Console.WriteLine(result);
        else Console.WriteLine("False");
    }
}
