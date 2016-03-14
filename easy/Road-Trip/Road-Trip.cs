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
            ShowDistances(line);
        }
    }
    
    static void ShowDistances(string line) {
            
        string[] cities = line.Substring(0,line.Length-1).Split(';');
        int leng = cities.Length;
        int[] distances = new int[leng];
        for (int i = 0; i < leng; i++) {
            int pos = cities[i].IndexOf(',');
            distances[i] = System.Convert.ToInt32(cities[i].Substring(pos + 1));
        }
        Array.Sort(distances);
        int j = 0;
        int last = 0;
        do {
            System.Console.Write(distances[j] - last);
            last = distances[j];
            j++;
            if (j < leng) {
                System.Console.Write(",");
            }
        } while (j < leng);
        System.Console.WriteLine();

    }
}
