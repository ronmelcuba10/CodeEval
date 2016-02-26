import java.io.*;
public class Main {
    public static void main(String[] args) throws FileNotFoundException, IOException {
        // TODO code application logic here
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            sum(line);
        }
    }

    private static void sum(String line) {
        int result = 0;
        for( int i=0; i<line.length();i++){
            result += Integer.valueOf(line.substring(i,i+1));
        }
        System.out.println(result);
    }
}
