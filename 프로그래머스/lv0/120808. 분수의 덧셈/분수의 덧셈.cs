using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {      
        int numer3 = numer1 * denom2 + numer2 *denom1;
        int denom3 = denom1 * denom2;
        
        int gcdInt = gcd(Math.Max(numer3, denom3), Math.Min(numer3, denom3));
        return new int[] {numer3 / gcdInt, denom3 / gcdInt};
    }
    
    int gcd (int a, int b){
        // gcd(유클리드 호제법) a와 b의 최대공약수는 b와 a%b의 최대공약수임
        
        // 나누어 떨어진다면?
        if (a % b == 0)
            return b;
            
            
        return gcd(b, a%b);
    }
    
    // 1. 두 분수르 더한다
    // 2. 분자와 분모의 최대공약수를 구한다.
    
}