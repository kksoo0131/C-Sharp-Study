using System;

public class Solution {
    public int solution(int a, int b) {
        int temp = 0;     
        while(temp != 1)
        {
            if (a>=b)
                temp = gcd(a,b);
            else if(b >a)
                temp = gcd(b,a);
            a /= temp;
            b /= temp;  
        }
        Console.Write(a+", "+b);
        
        while(true)
        {
            if (b % 2 ==0){
                b /= 2;
                continue;
            }
            if (b % 5 ==0){
                b /= 5;
                continue;
            }
            if (b == 1)
                return 1;
            return 2;
                        
        }
        
    }
    
    int gcd (int a, int b){
        if (a % b ==0){
            return b;
        }
        else
            return gcd(b, a%b);
    }
}