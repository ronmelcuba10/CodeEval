import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowMoveSteps(line);
        }
    }
    
    static void ShowMoveSteps(String line){
        String[] words = line.split(",");
        int row = words.length;
        int col = words[0].length();
        int steps = col;
        for(int i=0;i<row;i++){
            int intSteps = 0;
            boolean inX = true;
            boolean inY = false;
            int j = 0;
            while(!inY){
                inX = words[i].charAt(j) == 'X'; 
                inY = words[i].charAt(j) == 'Y'; 
                if(inX) intSteps =0;
                if(!inX && !inY)intSteps++;
                j++;
            }
            if (intSteps<steps)steps = intSteps;
        }
        System.out.println(steps);
    }
}
