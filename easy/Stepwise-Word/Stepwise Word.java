import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShoWord(line);
        }
    }
    
    public static void ShoWord(String line){
        String[] words = line.split(" ");
        int index = 0;
        for (int i=0;i<words.length;i++)if (words[i].length()>words[index].length())index = i;
        String word = words[index];
        int leng = word.length();
        for(int i=0;i<leng;i++){
            for(int j=0;j<i+1;j++){
                char ch = '*';
                if (i==j) ch = word.charAt(j);
                System.out.print(ch);
            }
            System.out.print(" ");
        }
        System.out.println();
    }
}
