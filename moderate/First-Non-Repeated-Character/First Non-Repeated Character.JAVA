import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowCharacter(line);
        }
    }
    
    static void ShowCharacter(String line){
        int size = line.length();
        int i = 0;
        while(i<size){
            int j = 0;
            while(j<size){
                char chI = line.charAt(i);
                char chJ = line.charAt(j);
                if(i!=j && chI == chJ) break;
                j++;
            }
            if (j==size) break;
            i++;
        }
        System.out.println(line.charAt(i));
    }
}
