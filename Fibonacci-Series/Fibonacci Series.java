import java.io.*;
public class Main {
    public static void main(String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            System.out.println(FibNumber(Integer.valueOf(line.trim())));
            // Process line of input Here
        }
    }

    private static int FibNumber(int num) {
        switch (num){
            case 0 : 
                return 0;
            case 1:
            case 2:
                return 1;
            default:
                int num1 = 1;
                int num2 = 1;
                int result = 2;
                for(int i = 2;i<num;i++){
                    result = num1 + num2;
                    num1 = num2;
                    num2 = result;
                }
                return result;
        }
    }
}
