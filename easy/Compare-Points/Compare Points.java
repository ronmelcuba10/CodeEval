import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowDirection(line);
        }
    }
    
    static void ShowDirection(String line){
        String result = "";
        String[] nums = line.split("\\s+");
        int x1 = Integer.valueOf(nums[0]);
        int y1 = Integer.valueOf(nums[1]);
        int x2 = Integer.valueOf(nums[2]);
        int y2 = Integer.valueOf(nums[3]);
        if(y1<y2) result = "N";
            else if (y1>y2 )result = "S";
                else result = "";
        if(x1<x2) result += "E";
            else if(x1>x2)result += "W";
        if(x1==x2 && y1==y2) result = "here";
        System.out.println(result);
    }
}
