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
            ShowLine(line);
        }
    }
    
    static void ShowLine(string line)
        {
            if (line.Length>55){
                line = line.Substring(0,40);
                if(line.IndexOf(" ")>=0){
                    int i = 39;
                    while(line[i]!=' ')i--;
                    line = line.Substring(0,i);
                }
                line = line + "... <Read More>";
            }
            System.Console.WriteLine(line);
        
        }
}
