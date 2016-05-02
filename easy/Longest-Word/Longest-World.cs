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
            ShowLongestWord(line);
        }
    }
    
    public static void ShowLongestWord(string line){
        string[] words = line.Split(' ');
        int size = 0;
        string longestword = "";
        foreach (string word in words){
            if (word.Length>size) {
                longestword = word; 
                size = longestword.Length;
            }
        }
        Console.WriteLine(longestword.Trim());
    }
}
