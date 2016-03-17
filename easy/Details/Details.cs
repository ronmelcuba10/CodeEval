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
            // do something with line
            ShowMoveSteps(line);
        }
    }
    
    static void ShowMoveSteps(string line){
            string[] words = line.Split(',');
            int row = words.Length;
            int col = words[0].Length;
            int steps = col;
            for(int i=0;i<row;i++){
                int intSteps = 0;
                bool inX = true;
                bool inY = false;
                int j = 0;
                while(!inY){
                    inX = words[i][j].Equals('X'); 
                    inY = words[i][j].Equals('Y'); 
                    if(inX) intSteps =0;
                    if(!inX && !inY)intSteps++;
                    j++;
                }
                if (intSteps<steps)steps = intSteps;
            }
            Console.WriteLine(steps);
        }
}
