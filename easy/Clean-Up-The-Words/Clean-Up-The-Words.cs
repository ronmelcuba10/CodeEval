using System;
using System.IO;
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
            ShowLine(line);
        }
    }
    
    static void ShowLine(string line){
            string pattern = @"([a-zA-Z]+)";
            MatchCollection matches = Regex.Matches(line, pattern);
            foreach (Match m in matches)
                Console.Write(m.Groups[1].Value.ToLower() + " ");
            
            Console.WriteLine();
        }
}
