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
            ShowNumber(line);
        }
    }
    
    static void ShowNumber(string line){
        string result = "0";
        double index = Convert.ToInt64(line);
        if(index==0) Console.WriteLine(0);
            else if(index==1) Console.WriteLine(1);
            else Console.WriteLine(GetDigit(index,(int)Math.Log(index,2)+1));
    }
        
    static char GetDigit(double pos, int rowPos){
        if(rowPos>0){
            int dig = (int)Char.GetNumericValue(
                                GetDigit(pos-Math.Pow(2,rowPos-1),
                                        (int)Math.Log(pos-Math.Pow(2,rowPos-1),2)+1)
                                );
            return (dig!=2? (dig+1).ToString()[0] : '0' );  
        } else return '0';
    }
}
