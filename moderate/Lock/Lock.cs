using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

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
            ShowNumberOfDoors(line);
        }
    }
    
    static void ShowNumberOfDoors(string line){
        int[] num = line.Split(' ').Select(str => Convert.ToInt32(str)).ToArray();
        bool[] locked = new bool[num[0]];
        for(int i=0;i<num[1]-1;i++){
            if(num[1]>1){
                for(int j=1;j<num[0];j+=2)    locked[j] = true;
                for(int z=num[0]-2;z>=0;z-=3) locked[z] = !locked[z];
            }
        }
        locked[num[0]-1] = !locked[num[0]-1];
        Console.WriteLine(locked.Where(lck => lck == false).Count());
    }
}
