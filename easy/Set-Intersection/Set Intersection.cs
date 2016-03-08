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
            ShowIntersection(line); 
        }
    }
    
    private static void ShowIntersection(string line) {
        int pos = line.IndexOf(";");
        string firstStr = line.Substring(0, pos);
        string[] second = line.Substring(pos + 1).Split(',');
        string result = "";
        for(int i=0;i<second.Length;i++) if(firstStr.Contains(second[i])) result = result + "," + second[i];
        if (result.Length>0)  System.Console.WriteLine(result.Substring(1));
        else System.Console.WriteLine();
    }
}
