import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            ShowMth(line);
        }
    }
    
    private static void ShowMth(String line){
		String[] elements = line.split(" ");
		int leng = elements.length-1;
		int number = Integer.valueOf(elements[leng]); 
		if (number <= elements.length-1 && number!=0)
		    System.out.println(elements[leng-number]);
	}
}
