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
            ShowBinary(line);
        }
    }
    
    public static void ShowBinary(string line){
        string bin = "";
        string[] zeros = line.Split(' ');
        int i=0;
        while(i<zeros.Length){
            if(zeros[i].Length==1){
                //zeros
                bin = bin + new string('0',zeros[i+1].Length); 
            }else {
                //ones
                bin = bin + new string('1',zeros[i+1].Length);
            }
            i+=2;
        }
        Console.WriteLine(Convert.ToInt64(bin, 2).ToString());
    }
}
