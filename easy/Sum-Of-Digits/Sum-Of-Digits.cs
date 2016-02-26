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
            sum(line.Trim());
        }
    }
    
    private static void sum(string line) {
        int result = 0;
        int num = Convert.ToInt32(line);
        while(num!=0){
            result += num%10;
            num = num/10;
        }
        Console.WriteLine(result);
    }
}
