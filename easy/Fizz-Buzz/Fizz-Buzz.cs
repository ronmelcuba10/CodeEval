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
            Showresult(line);
        }
    }
    
    static void Showresult(string line) {
        int[] nums = line.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        int fizz = nums[0];
        int buzz = nums[1];
        int max = nums[2];
        String Str = "";        
        for(int i=1; i<=max; i++){
            String result = "";
            if (i%fizz == 0 && i%buzz == 0) result = "FB";
            else if (i%fizz == 0) result += "F";
            else if (i%buzz == 0) result += "B";
            else result = i.ToString();
            Str = Str + " " + result;
        }
        Console.WriteLine(Str.Trim());
    }
}
