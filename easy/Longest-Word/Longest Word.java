import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowLongestWord(line);
        }
    }
    
    public static void ShowLongestWord(String line){
        String[] words = line.split(" ");
        int size = 0;
        String longestword = "";
        for (String word : words){
            if (word.length()>size) {
                longestword = word; 
                size = longestword.length();
            }
        }
        System.out.println(longestword.trim());
    }
}
