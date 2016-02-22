import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            TrailingStrings(line);
        }
    }
    
    private static void TrailingStrings(String line){
		String beforecomma = line.substring(0,line.indexOf(','));
        String aftercomma = line.substring(line.indexOf(',')+1);
        int lengA = aftercomma.length();
        int lengB = beforecomma.length();
        boolean equal = true;
        if(lengA<=lengB){
	        int i=0;
	        while(equal && i<lengA){
	        	equal = beforecomma.charAt(lengB-1-i)==aftercomma.charAt(lengA-1-i);
	        	i++;
	        }
		}else equal = false;
		if (equal) System.out.println("1");
		else System.out.println("0");
	}
}
