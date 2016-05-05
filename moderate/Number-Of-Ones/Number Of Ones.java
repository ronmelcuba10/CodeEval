import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            Show1s(line);
        }
    }
    
    static void Show1s(String line){
        String bin = Integer.toString(Integer.valueOf(line),2);
        System.out.println(bin.length() - bin.replace("1","").length());
    }
}
