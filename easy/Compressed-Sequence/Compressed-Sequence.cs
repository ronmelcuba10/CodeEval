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
            ShowSequence(line);
        }
    }
    
    static void ShowSequence(string line){
        string[] numStr = line.Split(' ');
        if(line.Length>0){
            if(line.Length==1) Console.WriteLine("1 " + numStr[0]);
            else {
                int counter = 1;
                int index = 0;
                for(int i=1; i<numStr.Length;i++){
                    if(numStr[i].Equals(numStr[index]))
                        counter++;
                    else {
                        Console.Write(counter + " " + numStr[i-1] + " ");
                        counter = 1;
                        index = i;
                    }
                }
                Console.Write(counter + " " + numStr[index]);
                Console.WriteLine();    
            }
        }
    }
}
