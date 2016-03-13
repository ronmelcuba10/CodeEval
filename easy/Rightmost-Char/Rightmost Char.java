import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowCharacter(line);
        }
    }
    
    public static void ShowCharacter(String line){
            line = line.trim();
            int leng=line.length();
            if(leng>1){
                int pos = -1;
                char ch = line.charAt(leng-1);
                for(int i=0;i<leng-2;i++)if(line.charAt(i)==ch)pos = i;
                System.out.println(pos);
            }
        }
}
