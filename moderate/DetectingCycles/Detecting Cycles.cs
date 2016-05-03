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
            Cycle(line);
        }
    }
    
    private static void Cycle(string line){
        string result = "";
        string[] numsStr = line.Split(' ');
        int leng = numsStr.Length; 
        if(leng >= 2){
            if(leng == 2){
                if (numsStr[0].Equals(numsStr[1])) result = numsStr[0];
            }else {
                int i = 0;
                bool found = false;
                while(!found && i<leng-1){
                    int j = i+1;
                    while (!found && j<leng){
                        if (numsStr[i].Equals(numsStr[j])) {
                            if (leng-j>=j-i){
                                result = getCycle(numsStr,i,j);
                                found = result.Length > 0;
                            }
                        }
                        j++;
                    }
                    i++;
                }
            }
        }
        Console.WriteLine(result.Trim());
    }
    
    private static string getCycle(string[] numsStr, int i, int j) {
        string result = "";
        int index = 0;
        int leng = numsStr.Length;
        bool isCycle = true;
        while (i+index<j && j+index<leng && isCycle){
            if(numsStr[i+index].Equals(numsStr[j+index])){
                result += numsStr[i+index] + " ";
                index++;
            } else isCycle = false;
        }
        if(!isCycle || i+index!=j) result = ""; 
        return result;
    }
}
