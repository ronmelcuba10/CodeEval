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
            ShowCharacter(line);
        }
    }
    
    public static void ShowCharacter(string line){
            line = line.Trim();
            int leng=line.Length;
            if(leng>1){
                int pos = -1;
                char ch = line[leng-1];
                for(int i=0;i<leng-2;i++)if(line[i]==ch)pos = i;
                System.Console.WriteLine(pos);
            }
        }
    
}
