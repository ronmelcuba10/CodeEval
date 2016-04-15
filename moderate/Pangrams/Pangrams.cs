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
            ShowPangram(line);
        }
    }
    
    static void ShowPangram(string line){
        line = line.ToLower();
        string result = "";
        char ch = 'a';
        for(int i=(int)ch;i<(int)ch+26;i++){
            if(line.IndexOf((char)i)<0)result += (char)i;
        }
        Console.WriteLine(result.Length==0? "NULL" : result);
    }
}
