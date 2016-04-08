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
            ShowRolerC(line);
        }
    }
    
    static void ShowRolerC(string line){
        bool up = true;
        for(int i=0;i<line.Length;i++){
            if (Char.IsLetter(line[i])){
                if(up) Console.Write(Char.ToUpper(line[i]));
                else   Console.Write(Char.ToLower(line[i]));
                up = !up;
            }else Console.Write(line[i]);
        }
        Console.WriteLine(); 
    }
}
