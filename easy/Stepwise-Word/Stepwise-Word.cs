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
                ShoWord(line);
            // do something with line
        }
    }
    
    public static void ShoWord(string line){
        string[] words = line.Split(' ');
        int index = 0;
        for (int i=0;i<words.Length;i++)if (words[i].Length>words[index].Length) index = i;
        string word = words[index];
        int leng = word.Length;
        for(int i=0;i<leng;i++){
            for(int j=0;j<i+1;j++){
                char ch = '*';
                if (i==j) ch = word[j];
                System.Console.Write(ch);
            }
            System.Console.Write(" ");
        }
        System.Console.WriteLine();
    }
}
