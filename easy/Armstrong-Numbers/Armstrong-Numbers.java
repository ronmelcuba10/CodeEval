import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowAmstrongNumber(line);
        }
    }
    
    static void ShowAmstrongNumber(String line){
        int num = Integer.valueOf(line);
        int numRefe = num;
        int leng = line.length();
        int sum = 0;
        while (num!=0){
            int digit = num%10;
            int pot = 1;
            for(int i=0;i<leng;i++) pot *= digit;
            num = num/10;
            sum += pot;
            }
        if (numRefe==sum) System.out.println("True");
        else System.out.println("False");
    }
}
