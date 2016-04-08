using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        int index = 0;
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            for(int i=0;i<line.Length;i++){
                if(".?!".IndexOf(line[i])>=0){
                    counter++;    
                    if (counter%2==0){
                        index++;
                        string text = ReplaceText(index%8);
                        line = line.Substring(0,i) + text + line.Substring(i+1); 
                        i+= text.Length;
                    }
                } 
            }
            Console.WriteLine(line);
        }
    }
    
    static string ReplaceText(int index){
        switch (index){
            case 1: return ", yeah!";
            case 2: return ", this is crazy, I tell ya.";
            case 3: return ", can U believe this?";
            case 4: return ", eh?";
            case 5: return ", aw yea.";
            case 6: return ", yo.";     
            case 7: return "? No way!";
            default: return ". Awesome!";    
        }
    }
}
