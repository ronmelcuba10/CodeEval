import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowWriter(line);
        }
    }
    
    static void ShowWriter(String line){
        int pos = line.indexOf("|");
        String str =line.substring(0,pos);
        String[] nums = line.substring(pos+1).trim().split("\\s+");
        for(String num : nums){
            System.out.print(str.charAt(Integer.valueOf(num)-1));
        }
        System.out.println();
    }
}
