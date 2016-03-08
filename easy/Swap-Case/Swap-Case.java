import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowInvertedSentence(line);
        }
    }
    
     public static void ShowInvertedSentence(String Rawline){
            char[] line = Rawline.toCharArray();
            String result = "";
            for(int i=0; i<line.length;i++) {
                result = result + InvertCase(String.valueOf(line[i]));
            }
            System.out.println(result);
        }
        
        public static String InvertCase(String ch){
            if (ch.matches("[a-z]")) return ch.toUpperCase();
            if (ch.matches("[A-Z]")) return ch.toLowerCase();
            return ch;
        }
    
}
