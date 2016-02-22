import java.io.*;
public class Main {
    public static void main(String[] args) throws FileNotFoundException, IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            String[] words = line.split(" ");
            showReversedOrder(words);
        }
    }

    private static void showReversedOrder(String[] words) {
        String result = "";
        for(int i=words.length-1; i>=0 ;i--){
            result += words[i] + " ";
        }
        System.out.println(result.trim());
    }
}
