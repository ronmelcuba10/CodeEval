import java.io.*;
public class Main {
    public static void main(String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            Cycle(line);
            // Process line of input Here
        }
    }

    private static void Cycle(String line){
        String result = "";
        String[] numsStr = line.split(" ");
        int leng = numsStr.length; 
        if(leng >= 2){
            if(leng == 2){
                if (numsStr[0].equals(numsStr[1])) result = numsStr[0];
            }else {
                int i = 0;
                boolean found = false;
                while(!found && i<leng-1){
                    int j = i+1;
                    while (!found && j<leng){
                        if (numsStr[i].equals(numsStr[j])) {
                            if (leng-j>=j-i){
                                result = getCycle(numsStr,i,j);
                                found = result.length() > 0;
                            }
                        }
                        j++;
                    }
                    i++;
                }
            }
        }
        System.out.println(result.trim());
    }
    
    private static String getCycle(String[] numsStr, int i, int j) {
        String result = "";
        int index = 0;
        int leng = numsStr.length;
        boolean isCycle = true;
        while (i+index<j && j+index<leng && isCycle){
            if(numsStr[i+index].equals(numsStr[j+index])){
                result += numsStr[i+index] + " ";
                index++;
            } else isCycle = false;
        }
        if(!isCycle || i+index!=j) result = ""; 
        return result;
    }
}
