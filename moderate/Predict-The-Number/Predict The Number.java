import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowNumber(line);
        }
    }
    
    static void ShowNumber(String line){
        String result = "0";
        double index = Double.valueOf(line);
        if(index==0) System.out.println(0);
            else if(index==1) System.out.println(1);
            else {
                int log2 = (int)((Math.log(index)/Math.log(2)));
                System.out.println(GetDigit(index,log2+1));
            } 
    }
        
    static char GetDigit(double pos, int rowPos){
        if(rowPos>0){
            int log2 = (int)(Math.log(pos-Math.pow(2,rowPos-1))/Math.log(2));
            char ch = GetDigit(pos-Math.pow(2,rowPos-1), log2+1);
            int dig = Integer.valueOf(Character.toString(ch));
            if(dig!=2) return Integer.toString(dig+1).charAt(0);
            else return '0';
        } else return '0';
    }
}
