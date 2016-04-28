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
            TrailingStrings(line);
        }
    }
    
    static void TrailingStrings(string line){
        int pos = line.IndexOf(',');
		string beforecomma = line.Substring(0,pos);
        string aftercomma = line.Substring(pos+1);
        int lengA = aftercomma.Length;
        int lengB = beforecomma.Length;
        bool equal = true;
        if(lengA<=lengB){
	        int i=0;
	        while(equal && i<lengA){
	        	equal = beforecomma[lengB-1-i]==aftercomma[lengA-1-i];
	        	i++;
	        }
		}else equal = false;
		Console.WriteLine(equal ? "1":"0");
	}
}
