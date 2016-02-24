import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            Capitalize(line);
        }
    }
    
    public static void Capitalize(String line){
        String[] words = line.split(" ");
        String result = "";
        for(int i=0;i<words.length;i++){
            result = result.concat(words[i].substring(0,1).toUpperCase() + words[i].substring(1,words[i].length()) + " ");
        }
        System.out.println(result);
    }
}
