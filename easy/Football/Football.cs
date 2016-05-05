using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

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
            ShowCountries(line);
        }
    }
    
    static void ShowCountries(string line){
        string[] countries = line.Trim().Split('|').Select(c => c.Trim()).ToArray();
        string clubStr = line.Replace("| ","");
        string result = "";
        int[] clubs = clubStr.Split(' ').Select(p => Int32.Parse(p)).Distinct().
                                OrderBy(p => p).ToArray();
        for(int i=0;i<clubs.Length;i++){
            result += clubs[i] + ":";
            for(int j=0;j<countries.Length;j++){
            if(countries[j].Split(' ').Select(c => Int32.Parse(c)).ToList().
                            Contains(clubs[i]))
                result += (j+1) + ",";
            }
            result = result.Substring(0,result.Length-1) + "; ";
        }
        Console.WriteLine(result);
    }
}
