import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowHappyNumber(line);
        }
    }
    
    public static void ShowHappyNumber(String line){
        if(line.trim().length()>0)
        {
            int num = Integer.valueOf(line);
            char result = GetHappyNumber(30,num);
            System.out.println(result);
        }
    }
    
    
    public static char GetHappyNumber(int deep, int num)
    {
        if (num == 1) return '1';
        else
        { 
            if (deep == 0 || num == 0) return '0';
            else
            {
                int DigSquares = 0;
                while (num!=0)
                {
                    DigSquares += (num%10)*(num%10);
                    num = num/10;
                }
                return GetHappyNumber(deep-1,DigSquares); 
            }
        }
    }
}
