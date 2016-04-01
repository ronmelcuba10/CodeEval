using System;
using System.IO;
using System.Collections;
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
            BlackDot(line);
        }
    }
    
    static void BlackDot(string line){
        int pos = line.IndexOf('|');
        string[] playersStr = line.Substring(0,pos).Trim().Split(' ');
        int dot = Convert.ToInt32(line.Substring(pos + 1).Trim());
        ArrayList players = new ArrayList();
        players.AddRange(playersStr);
        while(players.Count>1){
            int dotCounter = 1;
            int index = 0;
            while(true){
                if(dot!=dotCounter){
                    index++;
                    dotCounter++;
                    if(index==players.Count)index=0;
                }else {
                    players.RemoveAt(index);
                    break;
                }
            }
        }
        Console.WriteLine(players[0]);
    }
}
