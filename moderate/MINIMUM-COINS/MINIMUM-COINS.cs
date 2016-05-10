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
            int num = Convert.ToInt32(line);
            int result = num/5;
            num = num%5;
            result += num/3;
            result += num%3;
            Console.WriteLine(result);
        }
    }
}
