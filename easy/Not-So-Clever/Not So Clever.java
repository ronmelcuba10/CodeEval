import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowREsult(line);
        }
    }
    
    public static void ShowREsult(String line){
        line = line.trim();
        if(line.length()>0){
            int passes;
            char ch = line.charAt(line.length()-1);
            line = line.substring(0,line.indexOf('|')-1);
            if (ch!='0'){
                    passes = ChartoInt(ch);
                    String[] numsStr = line.split(" ");
                    int len = numsStr.length;
                    int[] nums = new int[len];
                    for(int i=0;i<len;i++) nums[i] = Integer.valueOf(numsStr[i]);
                    int j = 0;
                    int index = 0;
                    while(j<passes && index<len-1){
                        if (nums[index]>nums[index+1]) {
                            int tem = nums[index];
                            nums[index] = nums[index+1];
                            nums[index+1] = tem;
                            index=0;
                            j++;
                        } else index++;
                        
                    }
                    String result = "";
                    for(int num : nums) 
                        result += num + " ";
                   System.out.println(result.trim());
                } else System.out.println(line);
            }
        }
        
        public static int ChartoInt(char ch){
            int num;
            if(ch=='0')return 0;
                else if(ch=='1')return 1;
                else if(ch=='2')return 2;
                else if(ch=='3')return 3;
                else if(ch=='4')return 4;
                else if(ch=='5')return 5;
                else if(ch=='6')return 6;
                else if(ch=='7')return 7;
                else return 8;
        }
}
