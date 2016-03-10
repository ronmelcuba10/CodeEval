import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowNums(line);
        }
    }
    
    public static void ShowNums(String line){
        int pos = line.indexOf("|");
        String[] numsStr1 = line.substring(0,pos).trim().split(" ");
        String[] numsStr2 = line.substring(pos+1).trim().split(" ");
        int leng = numsStr1.length;
        for(int i=0;i<leng;i++){
            System.out.print(Integer.valueOf(numsStr1[i])
                            *Integer.valueOf(numsStr2[i]) + " ");
        }
        System.out.println();
        
        
    }
}
