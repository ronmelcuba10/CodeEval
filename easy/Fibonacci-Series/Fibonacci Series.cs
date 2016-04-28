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
            Console.WriteLine(FibNumber(line));
        }
    }
    
    static int FibNumber(string line) {
        int num = Convert.ToInt32(line);
        switch (num){
            case 0 : 
                return 0;
            case 1:
            case 2:
                return 1;
            default:
                int num1 = 1;
                int num2 = 1;
                int result = 2;
                for(int i = 2;i<num;i++){
                    result = num1 + num2;
                    num1 = num2;
                    num2 = result;
                }
                return result;
        }
    }
}
