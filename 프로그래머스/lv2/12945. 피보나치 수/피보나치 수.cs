using System;
public class Solution 
{
    int[] dp = new int[100001];
    
    public int solution(int n) 
    {
        return Fibo(n);
    }
    
    public int Fibo(int n)
    {
        if (n < 2) return n;
        
        
        if (dp[n] == 0)
        {
            dp[n] = Fibo(n-2) + Fibo(n-1);
        }
            
        return dp[n]% 1234567;
    }
}