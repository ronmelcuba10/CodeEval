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
            ShowWinner(line);
        }
    }
    
    static void ShowWinner(string line){
        string[] str = line.Split(' ');
        bool trump1 = str[0].IndexOf(str[3])>0;
        bool trump2 = str[1].IndexOf(str[3])>0;
        if (trump1 && !trump2) Console.WriteLine(str[0]);
        else if (!trump1 && trump2) Console.WriteLine(str[1]);
            else{
                string card1 = str[0].Substring(0,str[0].Length-1);
                string card2 = str[1].Substring(0,str[1].Length-1);
                if (card1.Equals(card2)) Console.WriteLine(str[0] + " " + str[1]);
                else Console.WriteLine(str[biggerCard(card1,card2)]);
            }
    }
    
    static int biggerCard(string card1, string card2){
        if (card1.Equals("A"))return 0;
        else if (card2.Equals("A")) return 1;
            else if (card1.Equals("K")) return 0;
            else if (card2.Equals("K")) return 1;
            else if (card1.Equals("Q")) return 0;
            else if (card2.Equals("Q")) return 1;
            else if (card1.Equals("J")) return 0;
            else if (card2.Equals("J")) return 1;
            else {
                int num1 = Convert.ToInt32(card1);
                int num2 = Convert.ToInt32(card2);
                if (num1>num2) return 0;
                    else return 1;
            }
    }
}
