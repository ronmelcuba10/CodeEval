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
            ShowString(line);
        }
    }
    
    static void ShowString(string line){
        string [] strs = line.Split(' ');
        string result ="";
        for(int i=0;i<strs[0].Length;i++){
            if(strs[1][i].Equals('1')) result += Char.ToUpper(strs[0][i]);
                else result += Char.ToLower(strs[0][i]);
        }
        Console.WriteLine(result);
    }
    
}
