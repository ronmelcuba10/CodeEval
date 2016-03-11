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
            // do something with line
            ShowBugPriority(line);
        }
    }
    
    static void ShowBugPriority(string line){
            int bug = 0;
            int pos = line.IndexOf('|');
            string deveStr = line.Substring(0,pos).Trim();
            string desiStr = line.Substring(pos+1).Trim();
            int leng = deveStr.Length;
            int leng1 = desiStr.Length;
            int finalLeng;
            if (leng<=leng1)finalLeng = leng;
            else finalLeng = leng1;
            for(int i=0;i<finalLeng;i++){
                if (deveStr[i]!=desiStr[i]) bug++;
            }
            bug += Math.Abs(leng-leng1);
            if(bug>6)System.Console.WriteLine("Critical");
            else if (bug>4) System.Console.WriteLine("High");
            else if (bug>2) System.Console.WriteLine("Medium");
            else if (bug>0) System.Console.WriteLine("Low");
            else System.Console.WriteLine("Done");
        }
    
}
