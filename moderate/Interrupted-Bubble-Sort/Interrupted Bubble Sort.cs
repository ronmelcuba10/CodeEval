using System.IO;
using System.Linq;
using System;
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
            ShowSortedList(line);
        }
    }
    
    static void ShowSortedList(string line){
        int pos = line.IndexOf('|');
        double op = Int64.Parse(line.Substring(pos+1));
        int[] nums = line.Substring(0,pos-1).Trim().Split(' ').
                            Select(s => Int32.Parse(s)).ToArray();
        double i = 0;  
        bool changeMade = true;
        int max  = nums.Length*nums.Length;
        while(i<op && i<max && changeMade){
            changeMade = false;
            for(int j=0;j<nums.Length-1;j++){
                if(nums[j]>nums[j+1]){
                    changeMade = true;
                    int temp = nums[j];
                    nums[j] = nums[j+1];
                    nums[j+1] = temp;
                }
            }
            i++;
        }
        foreach(int num in nums)Console.Write(num + " ");
        Console.WriteLine();
    }
}
