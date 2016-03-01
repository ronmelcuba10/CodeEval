import java.io.*;
public class Main {
    public static void main(String[] args) throws FileNotFoundException, IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            int n = Integer.valueOf(line.substring(line.indexOf(',')+1));
            int x = Integer.valueOf(line.substring(0,line.indexOf(',')));
            showNumbers(x,n);
        }
        
    }

    private static void showNumbers(int x, int n) {
        int i = 1;
        int multiple = 1;
        while (multiple<x){
            multiple = n*i;
            i++;
        }
        System.out.println(multiple);
    }
}
