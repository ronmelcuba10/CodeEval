import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowIntersection(line);
        }
    }
    
    private static void ShowIntersection(String line) {
        int pos = line.indexOf(";");
        String firstStr = line.substring(0, pos);
        String[] second = line.substring(pos + 1).split(",");
        String result = "";
        for(int i=0;i<second.length;i++) if(firstStr.contains(second[i])) result = result + "," + second[i];
        if (result.length()>0)  System.out.println(result.substring(1));
        else System.out.println();
    }
}
