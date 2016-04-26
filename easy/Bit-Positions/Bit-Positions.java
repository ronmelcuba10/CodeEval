import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowBitPos(line);
        }
    }
    
    static void ShowBitPos(String line){
        String[] nums = line.split(",");
        int num = Integer.valueOf(nums[0]);
        int pos1 = Integer.valueOf(nums[1]);
        int pos2 = Integer.valueOf(nums[2]);
        String binary = Integer.toBinaryString(num);
        int leng = binary.length();
        System.out.println(binary.charAt(leng-pos1) == binary.charAt(leng-pos2));
    }
}
