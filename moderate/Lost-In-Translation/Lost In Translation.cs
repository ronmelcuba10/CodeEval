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
            ShowSentence(line);
        }
    }
    
    static void ShowSentence(string line){
        var letters = new Dictionary<char,char>{
            {'a','y'},{'b','h'},{'c','e'},{'d','s'},
            {'e','o'},{'f','c'},{'g','v'},{'h','x'},
            {'i','d'},{'j','u'},{'k','i'},{'l','g'},
            {'m','l'},{'n','b'},{'o','k'},{'p','r'},
            {'q','z'},{'r','t'},{'s','n'},{'t','w'},
            {'u','j'},{'v','p'},{'w','f'},{'x','m'},
            {'y','a'},{'z','q'},{' ',' '}
        };
        foreach(char ch in line)Console.Write(letters[ch]);
        Console.WriteLine();
    }
}
