import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowAngle(line);
        }
    }
    
    static void ShowAngle(String line){
        int pos = line.indexOf(".");
        String angle = line.substring(0,pos);
        String str = line.substring(pos+1);
        int power = 1;
        for(int i=1; i<str.length()+1;i++)power*=10;
        long num = Integer.valueOf(str);
        long mins = num*60/power;
        long secs = num - ((mins*power)/60);
        long secsUnits = secs*3600/power;
        System.out.println(angle + "." + String.format("%02d",mins) +"'" + String.format("%02d",secsUnits) + "\"");
    }
}
