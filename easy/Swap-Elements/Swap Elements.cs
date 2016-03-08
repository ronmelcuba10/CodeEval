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
            ShoNums(line);
        }
    }
    
    public static void ShoNums(string line){
        string result = "";
        int pos  = line.IndexOf(":");
        string[] nums = line.Substring(0,pos).Split(' ');
        string[] swaps = line.Substring(pos+1).Split(',');
        for(int i=0;i<swaps.Length;i++){
            string sw = swaps[i].Trim();
            int dashpos = sw.IndexOf('-');
            int num1 = Convert.ToInt32(sw.Substring(0,dashpos));
            int num2 = Convert.ToInt32(sw.Substring(dashpos+1));
            string temp = nums[num1];
            nums[num1] = nums[num2];
            nums[num2] = temp;
        }
        for(int i=0;i<nums.Length;i++)Console.Write(nums[i] + " ");
        Console.WriteLine();
    }
}
