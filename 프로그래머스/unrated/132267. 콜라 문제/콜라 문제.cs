using System;

public class Solution {
    public int solution(int a, int b, int n) {
        // 빈병 a개 -> 콜라 b개
        // 빈병 n개 -> 콜라 ?개
        
        int answer = 0;
        while(n >= a)
        {
            n-=a;
            n+=b;
            answer += b;
        }
        
        return answer;
    }
}