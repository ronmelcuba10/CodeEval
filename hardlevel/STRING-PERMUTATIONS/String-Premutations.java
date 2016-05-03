import java.io.*;
import java.util.ArrayList;
import java.util.Collections;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            Showpermutations(line);
        }
    }
    
    public static void Showpermutations(String line) {
        String result = "";
        int size = line.length();
        if (size > 0) {
            ArrayList<String> myList = new ArrayList();
            getPermutations("", line, myList);
            Collections.sort(myList);
            for (String word:myList) result = result.concat(word+",");
            result = result.substring(0, result.length() - 1);
        }
        System.out.println(result);
    }

    public static void getPermutations(String beginningString, String endingString, ArrayList<String> myList) {
        if (endingString.length() <= 1) {
            myList.add(beginningString + endingString);
        } else {
            for (int i = 0; i < endingString.length(); i++) {
                String newString = endingString.substring(0, i) + endingString.substring(i + 1);
                getPermutations(beginningString + endingString.charAt(i), newString, myList);
            }
        }
    }
}
