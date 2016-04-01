using System;
using System.IO;
using System.Linq;
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
            ShowBeautyNumber(line);
        }
    }
    
    static void ShowBeautyNumber(string line){
        line = line.ToLower();
        string pattern = "[^a-z]";
        string replacement = "";
        Regex rgx = new Regex(pattern);
        string resultStr = rgx.Replace(line, replacement);
        Dictionary<char, int> myMap = new Dictionary<char, int>();
        foreach(char ch in resultStr){
            if(!myMap.ContainsKey(ch)){
                myMap.Add(ch,0);
                }
                myMap[ch] += 1;
            }
        List<KeyValuePair<char, int>> myList = myMap.ToList();
        myList.Sort((firstPair,nextPair) =>{
            return -firstPair.Value.CompareTo(nextPair.Value);
            });
        int beauty = 26;
        int result = 0;
        foreach(KeyValuePair<char, int> itm in myList){
            result += itm.Value*beauty;
            beauty--;
        }
        Console.WriteLine(result);
    }
}
