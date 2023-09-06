public class Solution 
{
    // dp문제인거 같은데?
    // dp[n] = dp[n-2] + dp[n-1]
    // 피보나치인데 1부터 시작
    int[] dp;
    
    public long solution(int n) 
    {
        dp = new int[n+1];
        
        if(n < 3){
            return n;
        }
        dp[1] = 1;
        dp[2] = 2;         
        
        
        for(int i=3; i<= n; i++)
        {
            dp[i] = (dp[i-2]+dp[i-1]) % 1234567;
        }
        
        return dp[n];
    }
}