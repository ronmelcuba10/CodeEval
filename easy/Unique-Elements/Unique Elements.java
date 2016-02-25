import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowUnique(line);
        }
    }
    
    public static void ShowUnique(String line){
        if (line.length()>0){
            String[] nums = line.split(",");
            String result = "";
            String numStr = "";
            int i = 0;
            while(i<nums.length){
                if(!nums[i].equals(numStr)){
                    numStr = nums[i];
                    result += numStr + ",";
                    i++;
                } else i++;
            }
            System.out.println(result.substring(0,result.length()-1));
        }
    }
}
