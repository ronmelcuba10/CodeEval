import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowLine(line);
        }
    }
    
    static void ShowLine(String line){
        if (line.length()>55){
            line = line.substring(0,40);
            if(line.indexOf(' ')>=0){
                int i = 39;
                while(line.charAt(i)!=' ')i--;
                line = line.substring(0,i);
            }
            line = line + "... <Read More>";
        }
        System.out.println(line);
    }
}
