import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            System.out.println(ShowModifiedLine(line));
        }
    }
    
    private static String ShowModifiedLine(String line){
        String sentence = line.substring(0,line.indexOf(','));
        String letters = line.substring(line.indexOf(',')+1).trim();
        int index = 0;
        while (index < letters.length()){
            sentence = sentence.replace(String.valueOf(letters.charAt(index)),"");
        	index++;
        }
        return sentence;
    }
}
