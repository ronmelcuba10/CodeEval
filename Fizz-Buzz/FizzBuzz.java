import java.io.*;
public class Main {
    public static void main(String[] args) throws FileNotFoundException, IOException {
        // TODO code application logic here
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            String[] nums = line.split(" ");
            showresult(nums[0],nums[1],nums[2]);
        }
    }

    private static void showresult(String s1, String s2, String sMax) {
        int fizz = Integer.valueOf(s1);
        int buzz = Integer.valueOf(s2);
        int max = Integer.valueOf(sMax);
        String Str = "";        
        for(int i=1; i<=max; i++){
            String result = "";
            if (i%fizz == 0 && i%buzz == 0) result = "FB";
            else if (i%fizz == 0) result += "F";
            else if (i%buzz == 0) result += "B";
            else result = String.valueOf(i);
            Str = Str + " " + result;
        }
        System.out.println(Str.trim());
    }
}
