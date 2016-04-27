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
            ShowOrdered(line);
        }
    }
    
    static void ShowOrdered(string line){
        string[] strs = line.Split('|');
        int iter = Convert.ToInt32(strs[1]);
        int[] nums = strs[0].Trim().Split(' ').Select(c => Convert.ToInt32(c)).ToArray();
        int leng = nums.Length;
        for (int i=0;i<iter;i++){
            for(int j=0;j<leng-1;j++){
                if(nums[j]>nums[j+1]){
                    int temp = nums[j];
                    nums[j] = nums[j+1];
                    nums[j+1] = temp;
                }
            }
            for(int j=leng-1;j>0;j--){
                if(nums[j-1]>nums[j]){
                    int temp = nums[j];
                    nums[j] = nums[j-1];
                    nums[j-1] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(" ", nums.Select(p=>p.ToString()).ToArray()));
    }
}
