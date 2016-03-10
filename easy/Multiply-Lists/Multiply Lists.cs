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
            ShowNums(line);
        }
    }
    
    public static void ShowNums(string line){
        int pos = line.IndexOf('|');
        string[] numsStr1 = line.Substring(0,pos).Trim().Split(' ');
        string[] numsStr2 = line.Substring(pos+1).Trim().Split(' ');
        int leng = numsStr1.Length;
        for(int i=0;i<leng;i++){
            Console.Write(Convert.ToInt32(numsStr1[i])
                            *Convert.ToInt32(numsStr2[i]) + " ");
        }
        Console.WriteLine();
        
        
    }
}
