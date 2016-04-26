using System.IO;
using System;
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
            ShowSquared(line);
        }
    }
    
    static void ShowSquared(string line){
        string[] pointsStr = line.Split(' ');
        int[,] points = new int[4,2];
        for(int i=0;i<4;i++){
            int pos1 = pointsStr[i].IndexOf('(');
            int pos2 = pointsStr[i].IndexOf(',');
            int pos3 = pointsStr[i].IndexOf(')');
            points[i,0] = Convert.ToInt32(pointsStr[i].Substring(1,1));
            points[i,1] = Convert.ToInt32(pointsStr[i].Substring(pos2+1,1));
        }
        Console.WriteLine(Squared(points)? "true":"false");
    }
    
    public static bool Squared(int[,] p){
        float d01 = distance(p[0,0],p[0,1],p[1,0],p[1,1]);
        float d02 = distance(p[0,0],p[0,1],p[2,0],p[2,1]);
        float d03 = distance(p[0,0],p[0,1],p[3,0],p[3,1]);
        float d12 = distance(p[1,0],p[1,1],p[2,0],p[2,1]);
        float d13 = distance(p[1,0],p[1,1],p[3,0],p[3,1]);
        float d23 = distance(p[2,0],p[2,1],p[3,0],p[3,1]);
        if(d01!=0 && d01==d12 && d12==d23 && d23==d03 && d02==d13)return true;
        if(d01!=0 && d02==d23 && d23==d13 && d13==d01 && d03==d12)return true;
        if(d01!=0 && d03==d13 && d13==d12 && d12==d02 && d01==d23)return true;
        return false;
    }
    
    public static float distance(int x1, int y1, int x2, int y2){
        return (float)Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
    }
}
