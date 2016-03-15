import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            GetNums(line);
        }
    }
    
    static void GetNums(String line){
        String[] artists = line.split("\\|");
        int arts = artists.length;
        int cate = artists[0].trim().split(" ").length;
        int[][] eval = new int[arts][cate]; 
        for(int i=0;i<arts;i++){
            String[] cateStr = artists[i].trim().split(" ");
            for(int j=0;j<cate;j++){
                eval[i][j] = Integer.valueOf(cateStr[j]); 
            }            
        }
        int max;
        for(int i=0;i<cate;i++){
            max=eval[0][i];;
            for(int j=0;j<arts;j++){
                if(eval[j][i]>max) max=eval[j][i];
            }
            System.out.print(max + " ");
        }
        System.out.println();
    }
}
