import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowLine(line);
        }
    }
    
    static void ShowLine(String line){
        String[] words = line.split("([^a-zA-Z]+)");
        String result = "";
        for(String word : words){
            result = result.concat(word + " ");
        }
        System.out.println(result.toLowerCase().trim());
    }
}
