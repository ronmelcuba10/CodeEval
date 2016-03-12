using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int posAnt=0;
        bool first=true;
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            line = line.Trim();
            int pos;
            char ch;
            int gatePos = line.IndexOf('_');
            int checPos = line.IndexOf('C');
            if (checPos>=0) pos=checPos;
                else pos=gatePos;
            if (!first) {
                if (pos>posAnt) ch='\\';
                else if (pos<posAnt) ch='/';
                    else ch = '|';
            }else {
                ch='|';
                first = false;
            }
            posAnt = pos;
            System.Console.WriteLine(line.Substring(0,pos)+ch+line.Substring(pos+1));
            
        }
    }
}
