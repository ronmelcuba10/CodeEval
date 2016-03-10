import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowValidity(line);
        }
    }
    
    static void ShowValidity(String line){
            String[] numsStr = line.split(" ");
            int sum = 0;
            for(int i=0;i<4;i++){
                int num = Integer.valueOf(numsStr[i]);
                for(int j=0;j<4;j++){
                    int digit = num%10;
                    num = num/10;
                    if (j%2!=0) sum += 2*digit;
                    else sum += digit;
                }
            }
            
            if (sum%10==0)System.out.println("Real");
            else System.out.println("Fake");
        }
    
}
