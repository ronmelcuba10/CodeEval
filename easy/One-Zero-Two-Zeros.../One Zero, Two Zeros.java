import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowResult(line);
        }
    }
    
    static void ShowResult(String line){
        int pos = line.indexOf(' ');
        int range = Integer.valueOf(line.substring(0,pos));
        int top = Integer.valueOf(line.substring(pos+1));
        int result = 0;
        for(int i=1;i<=top;i++){
            line  = Integer.toBinaryString(i);
            if (line.length() - line.replace("0", "").length() == range) result++;
        }
        System.out.println(result);
    }
}
