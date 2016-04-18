import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowVirusStopped(line);
        }
    }
    
    static void ShowVirusStopped(String line){
        int pos = line.indexOf("|");
        String[] virus = line.substring(0,pos-1).trim().split("\\s+");
        String[] antvirus = line.substring(pos+1).trim().split("\\s+");
        int antSum = 0;
        int virSum = 0;
        for(String str : virus) virSum += Integer.parseInt(str, 16);
        for(String str : antvirus) antSum += Integer.parseInt(str, 2);
        System.out.println(antSum>=virSum? "True":"False");
    }
}
