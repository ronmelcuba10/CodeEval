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
            invertElements(line);
        }
    }
    
    private static void invertElements(string line){
		string[] Str = line.Split(';');
		int k = Convert.ToInt32(Str[1]);
    	string[] numsStr = Str[0].Split(',');
		int leng = numsStr.Length;
		string result = "";
        for(int i=0;i<leng/k;i++){
			result += GetReversed(numsStr,i,k);
        }
		for(int i=k*(leng/k);i<leng;i++){
			result += (numsStr[i] + ",");
		}
        Console.WriteLine(result.Substring(0,result.Length-1));
	}

		
	private static string GetReversed(string[] numsStr,int i, int k){
		int init = i*k;
		int fin = i*k+k-1;
        string result = "";
        for(int j=fin;j>=init;j--){
            result += numsStr[j] + ",";
        }
        return result;
	}
}
