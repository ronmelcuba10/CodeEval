import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowPercentage(line);
        }
    }
    
    static void ShowPercentage(String line){
        int leng = line.length();
        int upper = 0;
        int lower = 0;
        for(int i=0;i<leng;i++){
            String ch = line.substring(i,i+1);
            if(ch.matches("[A-Z]")) upper++;
            else lower++;
        }
        System.out.printf("lowercase: %.2f", (float)lower*100/leng);
        System.out.printf(" uppercase: %.2f", (float)upper*100/leng);
        System.out.println();
    }
}
