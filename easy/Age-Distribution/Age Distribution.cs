using System;
using System.IO;
using System.Linq;
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
            ShowPhrase(line);
        }
    }
    static void ShowPhrase(string line){
        int age = Convert.ToInt32(line);
        var options = new Dictionary<Func<int,bool>,Action>{
            {ag => 0<=ag && ag<=2, () => Console.WriteLine("Still in Mama's arms")},
            {ag => 3<=ag && ag<=4, () => Console.WriteLine("Preschool Maniac")},
            {ag => 5<=ag && ag<=11,() => Console.WriteLine("Elementary school")},
            {ag => 12<=ag && ag<=14,() => Console.WriteLine("Middle school")},
            {ag => 15<=ag && ag<=18,() => Console.WriteLine("High school")},
            {ag => 19<=ag && ag<=22,() => Console.WriteLine("College")},
            {ag => 23<=ag && ag<=64,() => Console.WriteLine("Working for the man")},
            {ag => 66<=ag && ag<=100,() => Console.WriteLine("The Golden Years")},
            {ag => 0>ag||ag>66,() =>Console.WriteLine("This program is for humans")},
        };
        options.First(kvp => kvp.Key(age)).Value();
    }
}
