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
            ShowMoves(line);
        }
    }
    
    static void ShowMoves(string line){
            double col = line[0];
            double row = line[1];
            if(col-2>96 && row-1>48)Console.Write((char)(col-2) + "" + (char)(row-1) + " ");
            if(col-2>96 && row+1<57)Console.Write((char)(col-2) + "" + (char)(row+1) + " ");
            if(col-1>96 && row-2>48)Console.Write((char)(col-1) + "" + (char)(row-2) + " ");
            if(col-1>96 && row+2<57)Console.Write((char)(col-1) + "" + (char)(row+2) + " ");
            if(col+1<105 && row-2>48)Console.Write((char)(col+1) + "" + (char)(row-2) + " ");
            if(col+1<105 && row+2<57)Console.Write((char)(col+1) + "" + (char)(row+2) + " ");
            if(col+2<105 && row-1>48)Console.Write((char)(col+2) + "" + (char)(row-1) + " ");
            if(col+2<105 && row+1<57)Console.Write((char)(col+2) + "" + (char)(row+1) + " ");
            Console.WriteLine();
        }
}
