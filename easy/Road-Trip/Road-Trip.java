import java.io.*;
import java.util.Arrays;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
        ShowDistances(line);
            // Process line of input Here
        }
    }
    
    
    static void ShowDistances(String line) {
        String[] cities = line.split(";");
        int leng = cities.length;
        int[] distances = new int[leng];
        for (int i = 0; i < leng; i++) {
            int pos = cities[i].indexOf(",");
            distances[i] = Integer.valueOf(cities[i].substring(pos + 1));
        }
        Arrays.sort(distances);
        int i = 0;
        int last = 0;
        do {
            System.out.print(distances[i] - last);
            last = distances[i];
            i++;
            if (i < leng) {
                System.out.print(",");
            }
        } while (i < leng);
        System.out.println();

    }
}
