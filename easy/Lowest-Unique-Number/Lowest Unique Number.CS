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
            PrintWinner(line);
        }
    }
    
    public static void PrintWinner(string line){
        string[] players = line.Split(' ');
        string[] copyA = new string[players.Length];
        Array.Copy(players, 0, copyA, 0, players.Length);
        Array.Sort(players);
        int i=0;
        bool unique = false;
        while(i<players.Length && !unique){
            if (i==0){
                if(players[i].CompareTo(players[i+1])!=0) unique = true;
                else i++;
            }else if(i<players.Length-1){
                int comp1 = players[i].CompareTo(players[i-1]);
                int comp2 = players[i].CompareTo(players[i+1]);
                if (comp1!=0 && comp2!=0) unique = true;
                else i++;
            }else {
                int comp1 = players[i].CompareTo(players[i-1]);
                if (comp1!=0) unique = true;
                else i++;
            }
        }
        if(unique){
            int j = 0;
            while(!copyA[j].Equals(players[i]))j++;
            Console.WriteLine(j+1);
        }
        else Console.WriteLine(0);
    }
}
