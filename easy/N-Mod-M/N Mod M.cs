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
                ShoModulus(line);
            // do something with line
        }
    }
    
    public static void ShoModulus(string line){
        int firstNum = Convert.ToInt32(line.Substring(0,line.IndexOf(",")));
        int secondNum = Convert.ToInt32(line.Substring(line.IndexOf(",")+1));
        int num = firstNum / secondNum;
        Console.WriteLine(firstNum - num*secondNum);
    }
}
