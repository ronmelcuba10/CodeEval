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
            ShowResult(line);
        }
    }
    
    static void ShowResult(string line){
        int pos = line.IndexOf(' ');
        int range = System.Convert.ToInt32(line.Substring(0,pos));
        int top = System.Convert.ToInt32(line.Substring(pos+1));
        int result = 0;
        for(int i=1;i<=top;i++){
            if (System.Convert.ToString(i, 2).Split('0').Length-1 == range) result++;
        }
        System.Console.WriteLine(result);
    }
}
