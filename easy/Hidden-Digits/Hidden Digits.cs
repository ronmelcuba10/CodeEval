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
            // do something with line
            ShowHiddenDigits(line); 
        }
    }
    
    private static void ShowHiddenDigits(string line) {
        string result = "";
        int leng = line.Length;
        for (int i=0; i<leng; i++){
            result = result + getHiddenNumber(line[i]);
        }
        if (result.Length>0)Console.WriteLine(result);
        else Console.WriteLine("NONE");
    }

    private static string getHiddenNumber(char ch) {
        if("0123456789".IndexOf(ch)>=0) return ch.ToString();
        switch (ch){
            case 'a': return "0";
            case 'b': return "1";
            case 'c': return "2";
            case 'd': return "3";
            case 'e': return "4";
            case 'f': return "5";
            case 'g': return "6";
            case 'h': return "7";
            case 'i': return "8";
            case 'j': return "9";
        }
        return "";
    }
}
