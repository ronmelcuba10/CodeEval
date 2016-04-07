import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowMatrix(line);
        }
    }
    
    public static void ShowMatrix(String line){
        String[] cells = line.split(" ");
        int total = cells.length;
        int large = (int)Math.sqrt(total);
        for(int i=0;i<large;i++){
            for(int j=0; j<large;j++){
                System.out.print(cells[large*(large-j-1)+i ] + " ");
            }
        }
        System.out.println();
    }
}
