import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowIndex(line);
        }
    }
    
    static void ShowIndex(String line) {
        char[] chars = {'0','A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        int num = Integer.valueOf(line);
        String result ="";
        result = getColName(chars,num);
        System.out.println(result);
    }
    
    static String getColName(char[]chars,int num){
    	int u = 0;
    	int d = 0;
    	int m = 0;
    	for (int i=1;i<=num;i++){
			u++;
			if (u>26){
				u=1;
				d++;
				if (d>26){
					d=1;
					m++;
				}
			}
    	}
    	String result = "0";
    	if (u!=0) result = String.valueOf(chars[u]);
    	if (d!=0) result = String.valueOf(chars[d]) + result;
    	if (m!=0) result = String.valueOf(chars[m]) + result;
    	return result;
    }
}
