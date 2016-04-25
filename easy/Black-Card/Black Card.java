import java.io.*;
import java.util.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            BlackDot(line);
        }
    }
    
    static void BlackDot(String line){
        int pos = line.indexOf("|");
        String[] playersStr = line.substring(0,pos).trim().split("\\s+");
        int dot = Integer.valueOf(line.substring(pos + 1).trim());
        ArrayList<String> players = new ArrayList(Arrays.asList(playersStr));
        while(players.size()>1){
            int dotCounter = 1;
            int index = 0;
            while(true){
                if(dot!=dotCounter){
                    index++;
                    dotCounter++;
                    if(index==players.size())index=0;
                }else {
                    players.remove(index);
                    break;
                }
            }
        }
        System.out.println(players.get(0));
    }
}
