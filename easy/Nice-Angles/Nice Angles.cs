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
            ShowAngle(line);
        }
    }
    
    static void ShowAngle(string line){
        int pos = line.IndexOf('.');
        string angle = line.Substring(0,pos);
        string str = line.Substring(pos+1);
        int power = 1;
        for(int i=1; i<str.Length+1;i++)power*=10;
        long num = Convert.ToInt64(str);
        long mins = num*60/power;
        long secs = num - ((mins*power)/60);
        long secsUnits = secs*3600/power;
        Console.WriteLine(angle + "." + mins.ToString("00") +"\'" + secsUnits.ToString("00") + "\"");
    }
}
