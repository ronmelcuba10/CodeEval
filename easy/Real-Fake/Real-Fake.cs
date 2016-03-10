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
            ShowValidity(line);
        }
    }
    
    static void ShowValidity(string line){
            string[] numsStr = line.Split(' ');
            int sum = 0;
            for(int i=0;i<4;i++){
                int num = System.Convert.ToInt32(numsStr[i]);
                for(int j=0;j<4;j++){
                    int digit = num%10;
                    num = num/10;
                    if (j%2!=0) sum += 2*digit;
                    else sum += digit;
                }
            }
            
            if (sum%10==0)System.Console.WriteLine("Real");
            else System.Console.WriteLine("Fake");
        }
    
}
