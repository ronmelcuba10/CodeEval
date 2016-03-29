import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowAmount(line);
        }
    }
    
    static void ShowAmount(String line){
        String[] kids = line.split(",");
        int result = 0;
        int totalkids = 0;
        for(String kid : kids){
            int amt = Integer.valueOf(kid.substring(kid.indexOf(":")+2));
            if (kid.indexOf("V")>=0){
                totalkids += amt;
                result += 3*amt;
            } else if (kid.indexOf("Z")>=0){
                totalkids += amt;
                result += 4*amt;
            } else if (kid.indexOf("W")>=0){
                totalkids += amt;
                result += 5*amt;
            } else result *= amt;
        }
        System.out.println(result/totalkids);
    }
}
