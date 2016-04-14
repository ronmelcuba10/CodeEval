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
            ShowPrimes(line);
        }
    }
    
    static void ShowPrimes(string line){
        int pos = line.IndexOf(',');
        if(pos>0){
            int num1 = Convert.ToInt32(line.Substring(0,pos));
            int num2 = Convert.ToInt32(line.Substring(pos+1));
            int count = 0;
            for(int i=num1;i<=num2;i++) if(IsPrime(i)) count++;
            Console.WriteLine(count);    
        }
    }
    
    static bool IsPrime(int num){
        for(int i=2;i<num;i++){
            if(num%i==0)return false;
        }
        return true;
    }
}
