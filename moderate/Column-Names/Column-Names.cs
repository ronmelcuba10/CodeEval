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
            ShowIndex(line);
        }
    }
    
    static void ShowIndex(string line) {
        char[] chars = {'0','A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        int num = Convert.ToInt32(line);
        string result ="";
        result = getColName(chars,num);
        Console.WriteLine(result);
    }
    
    static string getColName(char[]chars,int num){
    	int u = 0;
    	int d = 0;
    	int m = 0;
    	for (int i=1;i<=num;i++){
			u++;
			if (u>26){
				u=1;
				d++;
				if (d>26){
					d=1;
					m++;
				}
			}
    	}
    	string result = "0";
    	if (u!=0) result = chars[u].ToString();
    	if (d!=0) result = chars[d].ToString() + result;
    	if (m!=0) result = chars[m].ToString() + result;
    	return result;
    }
}
