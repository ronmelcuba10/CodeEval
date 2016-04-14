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
            Console.WriteLine( ShowRotation(line) ? "True":"False");
        }
    }
    
    static bool ShowRotation(string line){
        string[] strs = line.Split(',');
        int leng = strs[0].Length;
        for(int i=0;i<leng;i++){
            strs[1] = strs[1].Substring(1)+strs[1][0];
            if(strs[0].Equals(strs[1])) return true;        
        }
        return false;
    }
}
