import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShoModulus(line);
        }
    }
    
    public static void ShoModulus(String line){
            
            int firstNum = Integer.valueOf(line.substring(0,line.indexOf(",")));
            int secondNum = Integer.valueOf(line.substring(line.indexOf(",")+1));
            int num = firstNum / secondNum;
            System.out.println(firstNum - num*secondNum);
    }
}
