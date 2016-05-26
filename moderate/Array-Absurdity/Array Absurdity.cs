using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

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
                
                
            bool[] dups=new bool[Int32.Parse(line.Substring(0,(line.IndexOf(';'))))];
            int[] nums = line.Substring(line.IndexOf(';')+1).Split(',').
                                        Select(n => Int32.Parse(n)).ToArray();
            int i = 0;
            while(i<nums.Length){
                if(!dups[nums[i]]) dups[nums[i]] = true;
                else break;
                i++;
            }
            Console.WriteLine(nums[i]);
        }
    }
}
