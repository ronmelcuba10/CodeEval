import java.io.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowDistance(line);
        }
    }
    
    static void ShowDistance(String line){
        String[] coords = line.split("\\)\\s+\\(");
        int pos1 = coords[0].indexOf(",");
        int pos2 = coords[1].indexOf(",");
        int x1 = Integer.valueOf(coords[0].substring(1,pos1));
        int y1 = Integer.valueOf(coords[0].substring(pos1+2));
        int x2 = Integer.valueOf(coords[1].substring(0,pos2));
        int y2 = Integer.valueOf(coords[1].substring(pos2+2,coords[1].length()-1));
        System.out.println((int)Math.sqrt((Math.pow((y1-y2),2) + Math.pow((x1-x2),2))));
    }
}
