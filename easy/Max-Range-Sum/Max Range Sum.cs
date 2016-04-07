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
            ShowMaximun(line);
        }
    }
    
    static void ShowMaximun(string line){
        int pos = line.IndexOf(';');
        int days = Convert.ToInt32(line.Substring(0,pos));
        string[] numsStr = line.Substring(pos+1).Split(' ');
        int leng = numsStr.Length;
        int[] nums = new int[leng];
        int sum = 0;
        for(int i=0;i<leng;i++)nums[i] = Convert.ToInt32(numsStr[i]);
        for(int i=0;i<leng-days+1;i++){
            int sumTemp = 0;
            for(int j=0;j<days;j++){
                sumTemp += nums[i+j];
            }
            if(sumTemp>sum)sum=sumTemp;
        }
        Console.WriteLine(sum);
    }
}
