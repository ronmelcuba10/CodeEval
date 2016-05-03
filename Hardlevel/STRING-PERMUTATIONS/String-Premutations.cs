using System;
using System.IO;
using System.Collections;
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
            Showpermutations(line);
        }
    }
    
    public class myOrderClass : IComparer  {
        int IComparer.Compare( Object x, Object y )  
        {
            string X = (string)x;
            string Y = (string)y;
            return string.CompareOrdinal(X, Y);
        }
    
    }
    
    public static void Showpermutations(string line) {
        string result = "";
        int size = line.Length;
        if (size > 0) {
            ArrayList myList = new ArrayList();
            getPermutations("", line, myList);
            myList.Sort(new myOrderClass());
            foreach(string word in myList) result += word + ",";
            result = result.Substring(0, result.Length - 1);
        }
        Console.WriteLine(result);
    }

    public static void getPermutations(string beginningString,string endingString, 
                                        IList myList) {
        if (endingString.Length <= 1) {
            myList.Add(beginningString + endingString);
        } else {
                for (int i = 0; i < endingString.Length; i++) {
                    string newString = endingString.Substring(0, i) + 
                                        endingString.Substring(i + 1);
                getPermutations(beginningString + endingString[i], 
                                newString, myList);
            }
        }
    }
}
