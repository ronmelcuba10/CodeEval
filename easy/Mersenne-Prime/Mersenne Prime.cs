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
            ShowMersenne(line);
        }
    }
    
    
    static void ShowMersenne(string line){
        double num = Convert.ToInt32(line);
        string result = "3";
        for(double i=3; Math.Pow(2,i)<num; i++){
            if(IsPrime(i) && i>2) result += ", " + (Math.Pow(2,i)-1);
        }
        Console.WriteLine(result.Trim());
    }
        
    static bool IsPrime(double num){
        for(double i=2;i<num;i++) if(num%i==0)return false;
        return true;  
    }
}
