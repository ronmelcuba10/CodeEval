using System;
using System.IO;
using System.Text.RegularExpressions;
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
            ShowSum(line);
        }
    }
    
    static void ShowSum(string line){
        line = line.Replace("\"","");
        int pos1 = line.IndexOf('[');
        int pos2 = line.IndexOf(']');
        string items = line.Substring(pos1+1,pos2-pos1-1);
        string pattern = @"\{id:\s(\d+),\slabel:\s\w+.+?\}+";
        MatchCollection matches = Regex.Matches(line, pattern);
        int sum = 0;
        foreach (Match match in matches){
            sum += Convert.ToInt32(match.Groups[1].Value);
        }
        Console.WriteLine(sum);
   }
}
