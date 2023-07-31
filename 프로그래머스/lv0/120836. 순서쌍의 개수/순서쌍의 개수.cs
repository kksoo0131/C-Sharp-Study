using System;

public class Solution {
    public int solution(int n) 
    {
        int answer = 0;   
        int num = 0;
        
        while (++num <= n)
        {
            if ( n % num == 0)
            {
                answer++;
            }
        }

        return answer;
    }
}