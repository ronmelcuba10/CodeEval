using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args) {
        // TODO code application logic here
        int num = 1000;
        while(num>0){
            bool isprime = isPrime(num);
            bool ispal = isPalindrome(num);
            if (ispal && isprime) break;
            num--;
        }
        Console.WriteLine(num);
    }

    static bool isPrime(int num) {
        for(int i=2; i<num; i++){
            if (num%i==0) return false;
        }
        return true;
    }

    static bool isPalindrome(int num) {
        string numStr = num.ToString();
        
        int i=0;
        int largo = numStr.Length;
        while(i<=largo/2){
            if( numStr[i] != numStr[largo-1-i] ) return false;
            i++;
        }
        return true;
    }
}
