using System;
using System.IO;
using System.Linq;
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
            ShowDeciphered(line);
        }
    }
    
    static void ShowDeciphered(string line){
        Dictionary<char,char> dec = new Dictionary<char,char>(){
            {'a','u'},{'b','v'},{'c','w'},{'d','x'},{'e','y'},{'f','z'},
            {'g','n'},{'h','o'},{'i','p'},{'j','q'},{'k','r'},{'l','s'},{'m','t'},
            {'n','g'},{'o','h'},{'p','i'},{'q','j'},{'r','k'},{'s','l'},{'t','m'},
            {'u','a'},{'v','b'},{'w','c'},{'x','d'},{'y','e'},{'z','f'}
        };
        for(int i=0;i<line.Length;i++) Console.Write(dec[line[i]]);
        Console.WriteLine();
    }
}
