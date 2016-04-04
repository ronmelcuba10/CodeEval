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
        int pos = line.IndexOf(';');
        string[] words = line.Substring(0,pos).Trim().Split(' ');
        string[] indexes = line.Substring(pos+1).Trim().Split(' ');
        int missingWordIndex = 0;
        int missingWordPos = 0;
        string result = "";
        for(int i=1;i<=indexes.Length+1;i++){
            int j = 0;
            while(true){
                if(indexes[j].Equals(i.ToString())) {
                    result += words[j] + " ";
                    break;
                } else {
                    j++;
                    if(j==words.Length-1){
                        missingWordPos = result.Length;
                        missingWordIndex = i;
                    break;
                    }
                }
            }
        }
        Console.WriteLine(result.Insert(missingWordPos, words[words.Length - 1] + " "));
    }
}
