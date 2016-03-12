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
            ShowNumber(line);
        }
    }
    
    static void ShowNumber(string line){
        string result = "";
        string[] numsStr = line.Split(';');
        foreach( string numStr in numsStr){
            result += GetDigit(numStr);
        }
        System.Console.WriteLine(result);
    }
    
    static string GetDigit(string numStr){
        switch (numStr){
            case "zero": return "0";
            case "one" : return "1";
            case "two" : return "2";
            case "three" : return "3";
            case "four" : return "4";
            case "five" : return "5";
            case "six" : return "6";
            case "seven" : return "7";
            case "eight" : return "8";
            default : return "9";
        }
    }
}
