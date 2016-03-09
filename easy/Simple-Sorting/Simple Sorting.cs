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
            // do something with line
            ShowOrderedList(line);
        }
    }
    
    public static void ShowOrderedList(string line){
        string[] numsStr = line.Split(' ');
        int leng = numsStr.Length;
        int index;
        string temp;
        for(int i=0;i<leng-1;i++){
            index = i;
            for(int j=i+1;j<leng;j++){
                float num1 = Convert.ToSingle(numsStr[index]);
                float num2 = Convert.ToSingle(numsStr[j]);
                if(num1>num2) index = j;
            }
            temp = numsStr[i];
            numsStr[i] = numsStr[index];
            numsStr[index] = temp;
        }
        string result = "";
        foreach(string num in numsStr) result = result + num + " ";
        System.Console.WriteLine(result.Trim());
    }
    
    
}
