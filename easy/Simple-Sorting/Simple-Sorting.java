import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowOrderedList(line);
        }
    }
    
        
    public static void ShowOrderedList(String line){
        String[] numsStr = line.split(" ");
        int leng = numsStr.length;
        int index;
        String temp;
        for(int i=0;i<leng-1;i++){
            index = i;
            for(int j=i+1;j<leng;j++){
                Float num1 = Float.valueOf(numsStr[index]);
                Float num2 = Float.valueOf(numsStr[j]);
                if(num1>num2) index = j;
            }
            temp = numsStr[i];
            numsStr[i] = numsStr[index];
            numsStr[index] = temp;
        }
        String result = "";
        for(String num : numsStr)result = result.concat(num+" ");
        System.out.println(result.trim());
    }
}
