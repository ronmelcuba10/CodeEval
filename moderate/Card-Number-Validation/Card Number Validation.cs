using System;
using System.IO;
using System.Linq;
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
            ShowValidity(line);
        }
    }
    
    static void ShowValidity(string line){
        int result = 0;
        line = line.Replace(" ","");
        int[] nums = line.Select(c => int.Parse(c.ToString())).Reverse().ToArray();
        for(int i=1;i<nums.Length;i+=2){
            int temp = nums[i]*2; 
            if(temp>9) temp = 1 + temp%10;
            nums[i] = temp;
        }
        foreach(int num in nums) result+=num;
        Console.WriteLine(result%10==0 ?"1":"0");
    }
}
