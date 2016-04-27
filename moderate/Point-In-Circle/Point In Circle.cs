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
            ShowIsInside(line);
        }
    }
    
    static void ShowIsInside(string line){
        string[] data = line.Split(';');
        int comma = data[0].IndexOf(',');
        float centerX = Convert.ToSingle(data[0].Substring(9,comma-9));
        float centerY = Convert.ToSingle(data[0].Substring(comma+2,data[0].Length-comma-3));
        float radius = Convert.ToSingle(data[1].Substring(9));
        comma = data[2].IndexOf(',');
        float pointX = Convert.ToSingle(data[2].Substring(9,comma-9));
        float pointY = Convert.ToSingle(data[2].Substring(comma+2,data[2].Length-comma-3));
        float distance = (float)Math.Sqrt((centerX-pointX)*(centerX-pointX)+(centerY-pointY)*(centerY-pointY)); 
        Console.WriteLine(distance<=radius?"true":"false");
    }
}
