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
            ShowPath(line);
        }
    }
    
    static void ShowPath(string line){
        string[] numsStr = line.Split(' ');
        int[] nums = new int[numsStr.Length];
        for(int i=0;i<numsStr.Length;i++)nums[i] = Convert.ToInt32(numsStr[i]);
        int min =nums[1];
        int max =0;
        for(int i=2;i<nums.Length;i++){
            if(nums[i]>max)max=nums[i];
            if(nums[i]<min)min=nums[i];
        }
        int dist = 10000000;
        int pos = min;
        for(int i=min;i<=max;i++){
            int temdist = GetDist(i,nums);
            if(dist>temdist){
                dist = temdist;
                pos=i;
            }
        }
        int sumOfdis =0;
        for(int i=1;i<nums.Length;i++) sumOfdis += Math.Abs(nums[i]-pos);
        Console.WriteLine(sumOfdis);
    }
        
    static int GetDist(int num, int[] nums){
        int result = 0;
        for(int i=1;i<nums.Length;i++)result += Math.Abs(nums[i]-num);
        return result;
    }
}
