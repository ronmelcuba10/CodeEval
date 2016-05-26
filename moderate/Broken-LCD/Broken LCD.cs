using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            ShowDigits(line);
        }
    }
    
    static void ShowDigits(string line){
        List<int> disp = line.Substring(0,line.IndexOf(';')).Split(' ').
                        Select(n => Convert.ToInt32(n,2)).ToList();
        string dig = line.Substring(line.IndexOf(';')+1);
        int leng = dig.Length-1;
        while(disp.Count>=leng){
            if(NumberCanBeDisplayed(disp,dig)){
                Console.WriteLine("1");
                return;
            }else disp.RemoveAt(0);
        }
        Console.WriteLine("0");
    }
        
    static bool NumberCanBeDisplayed(List<int> disp, string dig){
        int leng = dig.Length-1;
        int indDisp =0;    
        int indDig = 0;
        while(indDig<=leng){
            bool point = ( indDig<leng ? dig[indDig+1] == '.' : false);
            if(!DigitCanBeDisplayed(disp[indDisp],dig[indDig],point)) return false;
            if(point)indDig++; 
            indDig++;
            indDisp++;
        }
        return true;
    }
        
    static bool DigitCanBeDisplayed(int disp , char di ,bool point){
        int index = (int)Char.GetNumericValue(di);
        int[] needDispAr = new int[10] {252,96,218,242,102,182,190,224,254,246};
        int needDisp = needDispAr[index];
        if (point) needDisp = needDisp | 1;
        return (disp & needDisp) == needDisp;
    }
}
