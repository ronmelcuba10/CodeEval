import java.io.*;
public class Main {
    public static void main(String[] args) {
        // TODO code application logic here
        int sum = 0;
        int counter = 0;
        int i=2;
        while(counter <= 999){
            if (isPrime(i)){
                sum += i;
                counter ++;
            }
            i++;
        }
        System.out.println(sum);
    }

    private static boolean isPrime(int num) {
        for(int i=2; i<num; i++){
            if (num%i==0) return false;
        }
        return true;
    }
}
