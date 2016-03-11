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
            ShowAmstrongNumber(line);
        }
    }
    
    static void ShowAmstrongNumber(string line){
        int num = System.Convert.ToInt32(line);
        int numRefe = num;
        int leng = line.Length;
        int sum = 0;
        while (num!=0){
            int digit = num%10;
            int pot = 1;
            for(int i=0;i<leng;i++) pot *= digit;
            num = num/10;
            sum += pot;
            }
        if (numRefe==sum) System.Console.WriteLine("True");
        else System.Console.WriteLine("False");
    }
}
