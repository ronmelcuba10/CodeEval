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
            line = line.Trim();
            int n = Convert.ToInt32(line.Substring(line.IndexOf(',')+1));
            int x = Convert.ToInt32(line.Substring(0,line.IndexOf(',')));
            showNumbers(x,n);
        }
    }
    
    private static void showNumbers(int x, int n) {
        int i = 1;
        int multiple = 1;
        while (multiple<x){
            multiple = n*i;
            i++;
        }
        Console.WriteLine(multiple);
    }
}
