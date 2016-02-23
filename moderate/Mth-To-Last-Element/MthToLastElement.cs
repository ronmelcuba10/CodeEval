using System.IO;
using System.Collections.Generic;
using System;

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
            ShowMth(line);
        }
    }
    
    private static void ShowMth(String line){
		String[] elements = line.Split(' ');
		int leng = elements.Length-1;
		int number = Int32.Parse(elements[elements.Length-1]); 
		if (number <= elements.Length-1 && number!=0){
			Console.WriteLine(elements[leng-number]);
		}
		//for(String element : elements) System.out.println(element);
	}
}
