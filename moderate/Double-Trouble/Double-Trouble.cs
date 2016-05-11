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
            int leng = line.Length/2;
            int result = 1;
            for(int i=0;i<leng;i++){
                char f = line[i];
                char s = line[i+leng];
                if(f!=s && f!='*' && s!='*'){
                    result = 0;
                    break;
                }
                if(f=='*' && s=='*')result *=2;
            }
            Console.WriteLine(result);
        }
    }
}
