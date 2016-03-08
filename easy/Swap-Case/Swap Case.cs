using System;
using System.IO;
using System.Text;
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
            ShowInvertedSentence(line);
        }
    }
    
    
    public static void ShowInvertedSentence(string Rawline){
            StringBuilder line = new StringBuilder(Rawline);
            for(int i=0; i<line.Length;i++) line[i] = InvertCase(line[i]);
            System.Console.WriteLine(line);
        }
        
        public static char InvertCase(char ch){
            char result = ch;
            if (Regex.IsMatch(ch.ToString(),"[a-z]")) result = Char.ToUpper(ch);
            if (Regex.IsMatch(ch.ToString(),"[A-Z]")) result = Char.ToLower(ch);
            return result;
        }
    
}
