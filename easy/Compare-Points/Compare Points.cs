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
            ShowDirection(line);
        }
    }
    
    static void ShowDirection(string line){
            string result = "";
            string[] nums = line.Split(' ');
            int x1 = Convert.ToInt32(nums[0]);
            int y1 = Convert.ToInt32(nums[1]);
            int x2 = Convert.ToInt32(nums[2]);
            int y2 = Convert.ToInt32(nums[3]);
            if(y1<y2) result = "N";
                else if (y1>y2 )result = "S";
                    else result = "";
            if(x1<x2) result += "E";
                else if(x1>x2)result += "W";
            if(x1==x2 && y1==y2) result = "here";
            Console.WriteLine(result);
        }
}
