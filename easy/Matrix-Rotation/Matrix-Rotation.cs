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
            ShowMatrix(line);
        }
    }
    
    static void ShowMatrix(string line){
        string[] cells = line.Split(' ');
        int total = cells.Length;
        int large = (int)Math.Sqrt(total);
        for(int i=0;i<large;i++){
            for(int j=0; j<large;j++){
                Console.Write(cells[large*(large-j-1)+i ] + " ");
            }
        }
        Console.WriteLine();
    }
}
