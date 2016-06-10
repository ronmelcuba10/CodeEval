using System;
using System.Linq;
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
            ShowBlocks(line);
        }
    }
    
    public static void ShowBlocks(string line){
        int pos = line.IndexOf(' ');
        int[] sts = line.Substring(1,pos-2).Split(',').
                                Select(n => Int32.Parse(n)).ToArray();
        int[] avs = line.Substring(pos+2,line.Length-pos-3).Split(',').
                                Select(n => Int32.Parse(n) ).ToArray();
        int lastSts = sts.Length;
        int lastAvs = avs.Length;
        double m = (double)avs[lastAvs-1]/sts[lastSts-1];
        int blocks = 0;
        if(m!=0){
            for(int i=1; i<lastSts; i++){
                int j = 0;
                bool posibleInter = true;
                while(posibleInter && j<lastAvs-1){
                    if(m*sts[i]>avs[j] && m*sts[i-1]<avs[j+1])blocks++;
                    if(m*sts[i]<=avs[j]) posibleInter = false;
                    j++;
                }
            }
        }
        Console.WriteLine(blocks);
    }
}
