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
            ShowRoman(line);
        }
    }
    
    static void ShowRoman(string line){
        int num = Convert.ToInt32(line);
        int leng = line.Length;
        string result = "";
        for(int i=0; i<leng;i++) result += BuildRoman(leng-i,line[i]);
        Console.WriteLine(result);
    }
        
    static string BuildRoman(int power, char dig){
        string result = "";
        char [,] Roman = new char[4,2]{{' ','I'},
                                       {'V','X'},
                                       {'L','C'},
                                       {'D','M'}};
        switch(dig){
            case '1': return new string(Roman[power-1,1],1);
            case '2': return new string(Roman[power-1,1],2);
            case '3': return new string(Roman[power-1,1],3);
            case '4': return Roman[power-1,1].ToString()+Roman[power,0].ToString();
            case '5': return Roman[power,0].ToString();
            case '6': return Roman[power,0].ToString()+new string(Roman[power-1,1],1);
            case '7': return Roman[power,0].ToString()+new string(Roman[power-1,1],2);
            case '8': return Roman[power,0].ToString()+new string(Roman[power-1,1],3);
            case '9': return Roman[power-1,1].ToString()+Roman[power,1].ToString();
            default : return "";
        }
    }
}
