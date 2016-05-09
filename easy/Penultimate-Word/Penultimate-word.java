import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowWord(line);
        }
    }
    
    public static void ShowWord(String line){
        String[] result = line.split(" ");
        System.out.println(result[result.length-2].trim());
    }
}
