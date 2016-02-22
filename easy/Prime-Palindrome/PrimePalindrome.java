import java.io.*;
public class Main {
    public static void main(String[] args) {
        // TODO code application logic here
        int num = 1000;
        while(num>0){
            boolean isprime = isPrime(num);
            boolean ispal = isPalindrome(num);
            if (ispal && isprime) break;
            num--;
        }
        System.out.println(num);
    }

    private static boolean isPrime(int num) {
        for(int i=2; i<num; i++){
            if (num%i==0) return false;
        }
        return true;
    }

    private static boolean isPalindrome(int num) {
        String numStr = Integer.toString(num);
        int i=0;
        int largo = numStr.length();
        while(i<=largo/2){
            char ini = numStr.charAt(i);
            char fin = numStr.charAt(largo-1-i);
            if( ini != fin ) return false;
            i++;
        }
        return true;
    }
}
