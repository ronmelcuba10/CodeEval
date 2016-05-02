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
            ShowLongestWord(line);
        }
    }
    
    public static void ShowLongestWord(string line){
        bool selfname = true;
        int i = 0;
        while (i<line.Length && selfname){
            int j = 0;
            int cont = 0;
            while(j<line.Length && selfname){
                if(i==Convert.ToInt32(line[j].ToString()))cont++; 
                j++;
            }
            if (Convert.ToInt32(line[i].ToString()) != cont) selfname = false;
            i++;
        }
        Console.WriteLine(selfname?"1":"0");
    }
}
