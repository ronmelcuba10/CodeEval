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
            ShowUnique(line);
        }
    }
    
    public static void ShowUnique(string line){
        if (line.Length>0){
            string[] nums = line.Split(',');
            string result = "";
            string numStr = "";
            int i = 0;
            while(i<nums.Length){
                if(!nums[i].Equals(numStr)){
                    numStr = nums[i];
                    result += numStr + ",";
                    i++;
                } else i++;
            }
            System.Console.WriteLine(result.Substring(0,result.Length-1));
        }
    }
}
