using System;

public class Solution {
    //dp문제?
    
    // dp[5] = dp[5 - n] + 1 or dp [5 / 2 ] + 1 or dp [5 / 3] + 1
    public int solution(int x, int y, int n) 
    {
        int[] dp = new int[y+1];
        
        for(int i =0; i<y+1; i++){
            dp[i] = -1;
        }
        
        dp[x] = 0;
        
        for(int i= x+1; i <= y; i++)
        {
            int caculateN= int.MaxValue;
            int caculate2= int.MaxValue;
            int caculate3 = int.MaxValue;
            
            if (i > n && dp[i-n] != -1)
            {
                caculateN = dp[i-n] + 1;
            }
            
            if (i % 2 == 0 && dp[i/2] != -1)
            {
                caculate2 = dp[i/2] + 1;
            }
            
            if (i % 3 == 0 && dp [i/3] != -1)
            {
                caculate3 = dp[i/3] + 1;    
            }
                
            
            int min = Math.Min(caculateN, Math.Min(caculate2, caculate3));
            
            if (min == int.MaxValue)
            {
                dp[i] = -1;
            }
            else{
                dp[i] = min;
            }
            
            
        }
        
        
        return dp[y];
    }
}