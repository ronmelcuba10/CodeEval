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
            ShowPercentage(line);
        }
    }
    
    static void ShowPercentage(string line){
        int leng = line.Length;
        int upper = 0;
        int lower = 0;
        Regex rgx = new Regex(@"[A-Z]");
        for(int i=0;i<leng;i++){
            if(rgx.IsMatch(line.Substring(i,1))) upper++;
        }
        decimal upperporc = (decimal) upper*100/ (decimal) leng;
        Console.WriteLine($"lowercase: {100 - upperporc:N2} uppercase: {upperporc:N2}");
    }
}
