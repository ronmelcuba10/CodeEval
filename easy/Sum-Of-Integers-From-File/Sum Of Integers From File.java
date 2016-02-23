import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        int result = 0;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            result += Integer.valueOf(line);
        }
        System.out.println(result);
    }
}
