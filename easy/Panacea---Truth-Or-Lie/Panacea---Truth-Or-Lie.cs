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
            ShowVirusStopped(line);
        }
    }
    
    static void ShowVirusStopped(string line){
        int pos = line.IndexOf('|');
        string[] virus = line.Substring(0,pos-1).Trim().Split(' ');
        string[] antvirus = line.Substring(pos+1).Trim().Split(' ');
        int antSum = 0;
        int virSum = 0;
        foreach(string str in virus) virSum += Convert.ToInt32(str, 16);
        foreach(string str in antvirus) antSum += Convert.ToInt32(str, 2);
        Console.WriteLine(antSum>=virSum);
    }
    
    
}
