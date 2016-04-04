using System;
using System.IO;
using System.Collections.Generic;
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
            ShowPixels(line);
        }
    }

    static void ShowPixels(string line){
            string[] result = new string[6];
            Regex rgx = new Regex(@"[0-9]");
            for(int i=0;i<line.Length;i++){
                if(rgx.IsMatch(line[i].ToString())){
                    for(int j=0;j<5;j++) result[j] += DigitalSegment(line[i],j);
                    result[5] += "-----";
                }
            }
            foreach(string str in result)Console.WriteLine(str);
        }
        
        static string DigitalSegment(char num, int index){
            switch(num){
                case '0':
                    string[] digitSegment0 = new string[]{"-**--",
                                    "*--*-",
                                    "*--*-",
                                    "*--*-",
                                    "-**--"};
                    return digitSegment0[index];
                case '1':
                    string[] digitSegment1 = new string[]{"--*--",
                                    "-**--",
                                    "--*--",
                                    "--*--",
                                    "-***-"};
                    return digitSegment1[index];
                case '2':
                    string[] digitSegment2 = new string[]{"***--",
                                    "---*-",
                                    "-**--",
                                    "*----",
                                    "****-"};
                    return digitSegment2[index];
                case '3':
                    string[] digitSegment3 = new string[]{"***--",
                                    "---*-",
                                    "-**--",
                                    "---*-",
                                    "***--"};
                    return digitSegment3[index];
                case '4':
                    string[] digitSegment4 = new string[]{"-*---",
                                    "*--*-",
                                    "****-",
                                    "---*-",
                                    "---*-"};
                    return digitSegment4[index];
                case '5':
                    string[] digitSegment5 = new string[]{"****-",
                                    "*----",
                                    "***--",
                                    "---*-",
                                    "***--"};
                    return digitSegment5[index];
                case '6':
                    string[] digitSegment6 = new string[]{"-**--",
                                    "*----",
                                    "***--",
                                    "*--*-",
                                    "-**--"};
                    return digitSegment6[index];
                case '7':
                    string[] digitSegment7 = new string[]{"****-",
                                    "---*-",
                                    "--*--",
                                    "-*---",
                                    "-*---"};
                    return digitSegment7[index];
                case '8':
                    string[] digitSegment8 = new string[]{"-**--",
                                    "*--*-",
                                    "-**--",
                                    "*--*-",
                                    "-**--"};
                    return digitSegment8[index];
                default :
                    string[] digitSegment9 = new string[]{"-**--",
                                    "*--*-",
                                    "-***-",
                                    "---*-",
                                    "-**--"};
                    return digitSegment9[index];
            }
        }
}
