import java.util.*;
import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            PrintWinner(line);
        }
    }
    
    public static void PrintWinner(String line){
        String[] players = line.split(" ");
        String[] copyA = new String[players.length];
        System.arraycopy(players, 0, copyA, 0, players.length);
        Arrays.sort(players);
        int i=0;
        boolean unique = false;
        while(i<players.length && !unique){
            if (i==0){
                if(players[i].compareTo(players[i+1])!=0) unique = true;
                else i++;
            }else if(i<players.length-1){
                int comp1 = players[i].compareTo(players[i-1]);
                int comp2 = players[i].compareTo(players[i+1]);
                if (comp1!=0 && comp2!=0) unique = true;
                else i++;
            }else {
                int comp1 = players[i].compareTo(players[i-1]);
                if (comp1!=0) unique = true;
                else i++;
            }
        }
        if(unique){
            int j = 0;
            while(!copyA[j].equals(players[i]))j++;
            System.out.println(j+1);
        }
        else System.out.println(0);
    }
}
