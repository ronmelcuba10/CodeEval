import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            System.out.println(ShowPhrase(line));
        }
    }
    
    static String ShowPhrase(String line){
        int age = Integer.valueOf(line);
        if(age<0 || age>100) return "This program is for humans";
        if(age<3) return "Still in Mama's arms";
        if(age<5) return "Preschool Maniac";
        if(age<12) return "Elementary school";
        if(age<15) return "Middle school";
        if(age<19) return "High school";
        if(age<23) return "College";
        if(age<66) return "Working for the man";
        return "The Golden Years";
    }
}
