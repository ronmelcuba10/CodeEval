import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowSequence(line);
        }
    }
    
    static void ShowSequence(String line){
        String[] numStr = line.split("\\s+");
        if(line.length()>0){
            if(line.length()==1) System.out.println("1 " + numStr[0]);
            else {
                int counter = 1;
                int index = 0;
                for(int i=1; i<numStr.length;i++){
                    if(numStr[i].equals(numStr[index]))
                        counter++;
                    else {
                        System.out.print(counter + " " + numStr[i-1] + " ");
                        counter = 1;
                        index = i;
                    }
                }
                System.out.print(counter + " " + numStr[index]);
                System.out.println();    
            }
        }
    }
}
