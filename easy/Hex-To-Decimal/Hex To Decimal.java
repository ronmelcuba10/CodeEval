import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowDecimal(line);
        }
    }
    
    static void ShowDecimal(String line){
        int leng = line.length();
        double result = 0;
        double currentNum;
        for(int i=0;i<leng;i++){
            if("0123456789".indexOf(line.charAt(i))>=0){
                currentNum = Character.getNumericValue(line.charAt(i));
            }else {
                switch(line.charAt(i)){
                case 'a':
                    currentNum = 10;
                        break;
                case 'b':
                    currentNum = 11;
                    break;
                case 'c':
                    currentNum = 12;
                    break;
                case 'd':
                    currentNum = 13;
                    break;
                case 'e':
                    currentNum = 14;
                    break;
                default :
                    currentNum = 15;
                    break;
                }
            }
            result += currentNum * Math.pow(16, leng-i-1);
        }
        System.out.println((int)result);
    }
}
