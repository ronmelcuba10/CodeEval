import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        int[][] board = new int[256][256];
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            String[] str = line.split("\\s+");
            if (str[0].indexOf("Set")==0){
                int ind = Integer.valueOf(str[1]);
                int val = Integer.valueOf(str[2]);
                if(str[0].indexOf("Row")>0)for(int i=0;i<256;i++) board[ind][i] = val;
                else for(int i=0;i<256;i++)board[i][ind] = val;
            }else {
                int result = 0; 
                int ind = Integer.valueOf(str[1]);  
                if(str[0].indexOf("Row")>=0)for(int i=0;i<256;i++)result+=board[ind][i];
                else for(int i=0;i<256;i++) result += board[i][ind];
                System.out.println(result); 
                }
        }
    }
    
    
}
