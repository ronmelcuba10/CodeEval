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
            GetNums(line);
        }
    }
    
    static void GetNums(string line){
        string[] artists = line.Split('|');
        int arts = artists.Length;
        int cate = artists[0].Trim().Split(' ').Length;
        int[,] eval = new int[arts,cate]; 
        for(int i=0;i<arts;i++){
            string[] cateStr = artists[i].Trim().Split(' ');
            for(int j=0;j<cate;j++){
                eval[i,j] = Convert.ToInt32(cateStr[j]);   
            }            
        }
        int max;
        for(int i=0;i<cate;i++){
            max=eval[0,i];;
            for(int j=0;j<arts;j++){
                if(eval[j,i]>max) max=eval[j,i];
            }
            Console.Write(max + " ");
        }
        Console.WriteLine();
    }
}
