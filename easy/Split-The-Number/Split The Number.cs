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
            ShowResult(line);
        }
    }
    
    public static void ShowResult(string line){
        int pos = line.IndexOf(' ');
        string numsStr = line.Substring(0,pos);
        string patter = line.Substring(pos+1);
        int plusPos = patter.IndexOf('+');
        int minusPos = patter.IndexOf('-');
        int result = 0;
        if (plusPos>=0) {
            int num1 = System.Convert.ToInt32(numsStr.Substring(0,plusPos));
            int num2 = System.Convert.ToInt32(numsStr.Substring(plusPos));
            result = num1+num2;
        }else {
            int num1 = System.Convert.ToInt32(numsStr.Substring(0,minusPos));
            int num2 = System.Convert.ToInt32(numsStr.Substring(minusPos));
            result = num1-num2;
        }
      System.Console.WriteLine(result);
    } 
}
