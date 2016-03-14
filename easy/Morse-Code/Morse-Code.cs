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
            ShowMorse(line);
        }
    }
    
    static void ShowMorse(string line){
            string[] words = line.Split(new[] { "  " },StringSplitOptions.None);
            foreach(string word in words){
                PrintWord(word);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        
        static void PrintWord(string word){
            string[] letters = word.Split(' ');
            foreach(string letter in letters){
                Console.Write(Morse(letter));
            }
        }
        
        static char Morse(string letter){
            if (letter.Length<5){
                switch(letter){
                    case ".-" : return 'A';
                    case "-..." : return 'B';
                    case "-.-." : return 'C';
                    case "-.." : return 'D';
                    case "." : return 'E';
                    case "..-." : return 'F';
                    case "--." : return 'G';
                    case "...." : return 'H';
                    case ".." : return 'I';
                    case ".---" : return 'J';
                    case "-.-" : return 'K';
                    case ".-.." : return 'L';
                    case "--" : return 'M';
                    case "-." : return 'N';
                    case "---" : return 'O';
                    case ".--." : return 'P';
                    case "--.-" : return 'Q';
                    case ".-." : return 'R';
                    case "..." : return 'S';
                    case "-" : return 'T';
                    case "..-" : return 'U';
                    case "...-" : return 'V';
                    case ".--" : return 'W';
                    case "-..-" : return 'X';
                    case "-.--" : return 'Y';
                    default : return 'Z';
                }
            } else {
                switch(letter){
                    case "-----" : return '0';
                    case ".----" : return '1';
                    case "..---" : return '2';
                    case "...--" : return '3';
                    case "....-" : return '4';
                    case "....." : return '5';
                    case "-...." : return '6';
                    case "--..." : return '7';
                    case "---.." : return '8';
                    default : return '9';
                }
            }
        }
}
