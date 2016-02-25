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
            ShowHappyNumber(line);
        }
    }
    
    public static void ShowHappyNumber(string line){
        if(line.Trim().Length>0)
        {
            int num = System.Convert.ToInt32(line);
            char result = GetHappyNumber(30,num);
            System.Console.WriteLine(result);
        }
    }
    
    
    public static char GetHappyNumber(int deep, int num)
    {
        if (num == 1) return '1';
        else
        { 
            if (deep == 0 || num == 0) return '0';
            else
            {
                int DigSquares = 0;
                while (num!=0)
                {
                    DigSquares += (num%10)*(num%10);
                    num = num/10;
                }
                return GetHappyNumber(deep-1,DigSquares); 
            }
        }
    }
}
