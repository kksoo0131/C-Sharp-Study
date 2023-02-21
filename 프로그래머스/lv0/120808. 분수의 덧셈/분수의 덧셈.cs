using System;

public class Solution {
    static int gcd(int max,int min)
    {
        if (min == 0)
            return max;    
        return gcd(min, max%min);        
    }
        
    public int[] solution(int numer1, int denom1, int numer2, int denom2) 
    {
        int[] answer = new int[] {numer1 * denom2 + numer2 * denom1, denom1 * denom2};
        int r = 1;

        if (answer[0] > answer[1])
        {
            r = gcd(answer[0], answer[1]);
        }
        else 
        { 
            r = gcd(answer[1], answer[0]);
        }            
        
        
        answer[0] /= r;
        answer[1] /= r;
            

        return answer;
    }
}