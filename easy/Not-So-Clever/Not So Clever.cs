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
            ShowREsult(line);
        }
    }
    
    public static void ShowREsult(string line){
        line = line.Trim();
        if(line.Length>0){
            int passes;
            char ch = line[line.Length-1];
            line = line.Substring(0,line.IndexOf('|')-1);
            if (ch!='0'){
                    passes = ChartoInt(ch);
                    string[] numsStr = line.Split(' ');
                    int len = numsStr.Length;
                    int[] nums = new int[len];
                    for(int i=0;i<len;i++) nums[i] = Convert.ToInt32(numsStr[i]);
                
                
                    int j = 0;
                    int index = 0;
                    while(j<passes && index<len-1){
                        if (nums[index]>nums[index+1]) {
                            int tem = nums[index];
                            nums[index] = nums[index+1];
                            nums[index+1] = tem;
                            index=0;
                            j++;
                        } else index++;
                        
                    }
                    String result = "";
                    foreach(int num in nums) 
                        result += num + " ";
                    Console.WriteLine(result.Trim());
                } else Console.WriteLine(line);
            }
        }
        
        public static int ChartoInt(char ch){
            int num;
            if(ch=='0')return 0;
                else if(ch=='1')return 1;
                else if(ch=='2')return 2;
                else if(ch=='3')return 3;
                else if(ch=='4')return 4;
                else if(ch=='5')return 5;
                else if(ch=='6')return 6;
                else if(ch=='7')return 7;
                else return 8;
        }
}
