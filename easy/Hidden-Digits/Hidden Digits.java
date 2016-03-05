import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowHiddenDigits(line);
        }
    }
    private static void ShowHiddenDigits(String line) {
        String result = "";
        int leng = line.length();
        for (int i=0; i<leng; i++){
            result = result + getHiddenNumber(line.charAt(i));
        }
        if (result.length()>0)System.out.println(result);
        else System.out.println("NONE");
    }

    private static String getHiddenNumber(char ch) {
        if("0123456789".indexOf(ch)>=0) return String.valueOf(ch);
        switch (ch){
            case 'a': return "0";
            case 'b': return "1";
            case 'c': return "2";
            case 'd': return "3";
            case 'e': return "4";
            case 'f': return "5";
            case 'g': return "6";
            case 'h': return "7";
            case 'i': return "8";
            case 'j': return "9";
        }
        return "";
    }
}
