import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowMorse(line);
        }
    }
    
    static void ShowMorse(String line){
            String[] words = line.split("  ");
            for(String word : words){
                PrintWord(word);
                System.out.print(" ");
            }
            System.out.println();
        }
        
        static void PrintWord(String word){
            String[] letters = word.split(" ");
            for(String letter : letters){
                System.out.print(Morse(letter));
            }
        }
        
        static char Morse(String letter){
            if (letter.length()<5){
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
