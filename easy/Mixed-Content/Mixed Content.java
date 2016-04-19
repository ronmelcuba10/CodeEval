import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowLine(line);
        }
    }
    
    static void ShowLine(String line){
        String[] words = line.split(",");
        int total = words.length;
        String result = "";
        for(int i=0;i<total;i++){
            if(!words[i].matches("\\d+")) result += words[i] + ',';
        }
        if(result.length()>0)result = result.substring(0,result.length()-1) + '|' ;
        for(int i=0;i<total;i++){
            if(words[i].matches("\\d+"))result += words[i] + ',';
        }
        System.out.println(result.substring(0,result.length()-1));
    }
}
