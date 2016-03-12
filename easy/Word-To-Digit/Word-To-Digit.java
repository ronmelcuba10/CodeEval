import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowNumber(line);
        }
    }
    
    static void ShowNumber(String line){
        String result = "";
        String[] numsStr = line.split(";");
        for(String numStr : numsStr){
            result += GetDigit(numStr);
        }
        System.out.println(result);
    }
    
    static String GetDigit(String numStr){
        switch (numStr){
            case "zero": return "0";
            case "one" : return "1";
            case "two" : return "2";
            case "three" : return "3";
            case "four" : return "4";
            case "five" : return "5";
            case "six" : return "6";
            case "seven" : return "7";
            case "eight" : return "8";
            default : return "9";
        }
    }
}
