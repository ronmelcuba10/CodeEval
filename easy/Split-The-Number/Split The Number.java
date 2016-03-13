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
    
    public static void ShowResult(String line){
        int pos = line.indexOf(" ");
        String numsStr = line.substring(0,pos);
        String patter = line.substring(pos+1);
        int plusPos = patter.indexOf("+");
        int minusPos = patter.indexOf("-");
        int result = 0;
        if (plusPos>=0) {
            int num1 = Integer.valueOf(numsStr.substring(0,plusPos));
            int num2 = Integer.valueOf(numsStr.substring(plusPos));
            result = num1+num2;
        }else {
            int num1 = Integer.valueOf(numsStr.substring(0,minusPos));
            int num2 = Integer.valueOf(numsStr.substring(minusPos));
            result = num1-num2;
        }
      System.out.println(result);
    } 
}
