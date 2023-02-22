using System;

public class Solution {
    public int solution(int n) {   
        // 1로 나눴을때 소숫점이 있다면 제곱수가 아님
        return Math.Sqrt(n) % 1 == 0 ? 1 : 2;
        
    }
}