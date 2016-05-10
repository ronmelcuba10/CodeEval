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
            ShowOverlapping(line);
        }
    }
    
    static void ShowOverlapping(string line){
        string[] coordsStr = line.Split(',');
        int xU1 = Convert.ToInt32(coordsStr[0]);
        int yU1 = Convert.ToInt32(coordsStr[1]);
        int xL1 = Convert.ToInt32(coordsStr[2]);
        int yL1 = Convert.ToInt32(coordsStr[3]);
        int xU2 = Convert.ToInt32(coordsStr[4]);
        int yU2 = Convert.ToInt32(coordsStr[5]);
        int xL2 = Convert.ToInt32(coordsStr[6]);
        int yL2 = Convert.ToInt32(coordsStr[7]);
        if (RectInsideOther(xU1,yU1,xL1,yL1,xU2,yU2,xL2,yL2) || 
            RectInsideOther(xU2,yU2,xL2,yL2,xU1,yU1,xL1,yL1)) 
            Console.WriteLine("True");
        else Console.WriteLine("False");
    }
    
    static bool RectInsideOther(int xU1,int yU1,int xL1,int yL1,int xU2,int yU2,int xL2,int yL2){
        return ((xU1<=xU2 && xU2<=xL1 && yU1>=yU2 && yU2>=yL1) ||
                (xU1<=xL2 && xL2<=xL1 && yU1>=yU2 && yU2>=yL1) ||
                (xU1<=xL2 && xL2<=xL1 && yU1>=yL2 && yL2>=yL1) ||
                (xU1<=xU2 && xU2<=xL1 && yU1>=yL2 && yL2>=yL1));
    }
}
