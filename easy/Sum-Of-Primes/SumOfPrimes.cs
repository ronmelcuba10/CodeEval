using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        int sum = 0;
        int i = 2;
        while(counter <= 999){
            if (isPrime(i)){
                sum += i;
                counter++;
            }
            i++;
        }
        Console.WriteLine(sum);
    }

    static bool isPrime(int num) {
        for(int i=2; i<num; i++){
            if (num%i==0) return false;
        }
        return true;
    }
    
}
