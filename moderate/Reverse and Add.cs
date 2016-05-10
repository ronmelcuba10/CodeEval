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
            ShowFinalnumber(System.Convert.ToInt32(line));
        }
    }

    private static void ShowFinalnumber(int num) {
        int i = 0;
        while(!isPalindrome(num)){
            num += InverseNum(num);
            i++;
        }
        System.Console.WriteLine($"{i} {num}");
    }

    private static int InverseNum(int num) {
        int inverted = 0;
        while (num != 0) {
            inverted = inverted * 10;
            inverted = inverted + num % 10;
            num = num / 10;
        }
        return inverted;
    }

    private static bool isPalindrome(int num) {
        return num==InverseNum(num);
    }
}
