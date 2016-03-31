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
            ShowDecimal(line);
        }
    }
    
    static void ShowDecimal(string line){
        int leng = line.Length;
        double result = 0;
        double currentNum;
        for(int i=0;i<leng;i++){
            if("0123456789".IndexOf(line[i])>=0){
                currentNum = Char.GetNumericValue(line[i]);
            }else {
                switch(line[i]){
                case 'a':
                    currentNum = 10;
                        break;
                    case 'b':
                        currentNum = 11;
                        break;
                    case 'c':
                        currentNum = 12;
                        break;
                    case 'd':
                        currentNum = 13;
                        break;
                    case 'e':
                        currentNum = 14;
                        break;
                    default :
                        currentNum = 15;
                        break;
                    }
            }
            result += currentNum * Math.Pow(16, leng-i-1);
        }
        Console.WriteLine(result);
    }
}
