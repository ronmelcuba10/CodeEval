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
            // do something with line
            ShowLine(line);
        }
    }
    
    static void ShowLine(string line){
            string[] words = line.Split(',');
            Regex rgx = new Regex(@"\d+");
            int total = words.Length;
            string result = "";
            for(int i=0;i<total;i++){
                if(!rgx.IsMatch(words[i])) result += words[i] + ',';
            }
            if(result.Length>0)result = result.Substring(0,result.Length-1) + '|' ;
            for(int i=0;i<total;i++){
                if(rgx.IsMatch(words[i]))result += words[i] + ',';
            }
            Console.WriteLine(result.Substring(0,result.Length-1));
        }
}
