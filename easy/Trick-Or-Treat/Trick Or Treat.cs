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
            ShowAmount(line);
        }
    }
    
    static void ShowAmount(string line){
        string[] kids = line.Split(',');
        int result = 0;
        int totalkids = 0;
        foreach(string kid in kids){
            int amt = Convert.ToInt32(kid.Substring(kid.IndexOf(':')+2));
            if (kid.IndexOf('V')>=0){
                totalkids += amt;
                result += 3*amt;
            } else if (kid.IndexOf('Z')>=0){
                totalkids += amt;
                result += 4*amt;
            } else if (kid.IndexOf('W')>=0){
                totalkids += amt;
                result += 5*amt;
            } else result *= amt;
        }
        Console.WriteLine(result/totalkids);
    }
}
