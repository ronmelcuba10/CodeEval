import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            System.out.println(ShowModifiedLine(line));
        }
    }
    
    private static String ShowModifiedLine(String line){
        String sentence = line.substring(0,line.indexOf(','));
        String letters = line.substring(line.indexOf(',')+1).trim();
        int index = 0;
        while (index < sentence.length()){
        	if (hasLettersSentenceI(sentence,index,letters)){
        		sentence = sentence.substring(0,index) + sentence.substring(index+1);
        	} else index++;
        }
        return sentence;
    }
    
    private static boolean hasLettersSentenceI(String sentence,int index,String letters){
    	String letter = sentence.substring(index,index+1);
    	return letters.indexOf(letter)>=0;
    }
}
