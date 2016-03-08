import java.io.*;
import java.util.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShoNums(line);
        }
    }
    
    public static void ShoNums(String line){
        String result = "";
        int pos  = line.indexOf(":");
        String[] nums = line.substring(0,pos).split(" ");
        String[] swaps = line.substring(pos+1).split(",");
        for(int i=0;i<swaps.length;i++){
            String sw = swaps[i].trim();
            int dashpos = sw.indexOf("-");
            int num1 = Integer.valueOf(sw.substring(0,dashpos));
            int num2 = Integer.valueOf(sw.substring(dashpos+1));
            String temp = nums[num1];
            nums[num1] = nums[num2];
            nums[num2] = temp;
        }
        for(int i=0;i<nums.length;i++)System.out.print(nums[i] + " ");
        System.out.println();
    }
}
