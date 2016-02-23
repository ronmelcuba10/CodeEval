import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            invertElements(line);
        }
    }
    private static void invertElements(String line){
		if (line.length()>0 && line.indexOf(";")>=0){
			String[] numsStr = line.split(",");
			int leng = numsStr.length;
			String last = numsStr[leng-1];
			int k = Integer.valueOf(last.substring(last.indexOf(";")+1));
			numsStr[leng-1] = last.substring(0,last.indexOf(";"));
			
			
            String result = "";
            for(int i=0;i<leng/k;i++){
				result = result.concat(GetReversed(numsStr,i,k));
            }
			for(int i=k*(leng/k);i<leng;i++){
				result = result = result.concat(numsStr[i] + ",");
			}
            
            result = result.substring(0,result.length()-1);
			System.out.println(result);
		}
	}
		
	private static String GetReversed(String[] numsStr,int i, int k){
		int init = i*k;
		int fin = i*k+k-1;
        String result = "";
        for(int j=fin;j>=init;j--){
            result = result.concat(numsStr[j] + ",");
        }
        return result;
	}
}
