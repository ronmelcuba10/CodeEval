using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[,] board = new int[256,256];
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream){
            string line = reader.ReadLine();
            if (null == line)
                continue;
            string[] str = line.Split(' ');
            if (str[0].IndexOf("Set")==0){
                int ind = Convert.ToInt32(str[1]);
                int val = Convert.ToInt32(str[2]);
                if(str[0].IndexOf("Row")>0)for(int i=0;i<256;i++) board[ind,i] = val;
                else for(int i=0;i<256;i++)board[i,ind] = val;
            }else {
                int result = 0; 
                int ind = Convert.ToInt32(str[1]);  
                if(str[0].IndexOf("Row")>=0)for(int i=0;i<256;i++)result+=board[ind,i];
                else for(int i=0;i<256;i++) result += board[i,ind];
                Console.WriteLine(result); 
                }
        }
    }
}
