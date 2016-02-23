import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowLongestWord(line);
        }
    }
    
    public static void ShowLongestWord(String line){
        String[] digs = line.split("");
        boolean selfname = true;
        int i = 0;
        while (i<digs.length && selfname){
            int j = 0;
            int cont = 0;
            while(j<digs.length && selfname){
                if(i==Integer.valueOf(digs[j]))cont++; 
                j++;
            }
            if (Integer.valueOf(digs[i]) != cont) selfname = false;
            i++;
        }
        if(selfname) System.out.println("1");
        else System.out.println("0");
    }
}
