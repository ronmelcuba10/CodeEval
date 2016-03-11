import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowBugPriority(line);
        }
    }
    
    static void ShowBugPriority(String line){
            int bug = 0;
            int pos = line.indexOf("|");
            String deveStr = line.substring(0,pos).trim();
            String desiStr = line.substring(pos+1).trim();
            int leng = deveStr.length();
            int leng1 = desiStr.length();
            int finalLeng;
            if (leng<=leng1)finalLeng = leng;
            else finalLeng = leng1;
            for(int i=0;i<finalLeng;i++){
                if (deveStr.charAt(i)!=desiStr.charAt(i)) bug++;
            }
            bug += Math.abs(leng-leng1);
            if(bug>6)System.out.println("Critical");
            else if (bug>4) System.out.println("High");
            else if (bug>2) System.out.println("Medium");
            else if (bug>0) System.out.println("Low");
            else System.out.println("Done");
        }
}
