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
            ShowBitPos(line);
        }
    }
    
    static void ShowBitPos(string line){
        string[] nums = line.Split(',');
        int num = Convert.ToInt32(nums[0]);
        int pos1 = Convert.ToInt32(nums[1]);
        int pos2 = Convert.ToInt32(nums[2]);
        string binary = Convert.ToString(num, 2);
        int leng = binary.Length;
        Console.WriteLine(binary[leng-pos1].Equals(binary[leng-pos2]).ToString().ToLower());
    }
    
}
