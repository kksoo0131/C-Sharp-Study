using System;

public class Solution {
    public long solution(int balls, int share) {
        return (long)share == 0 ? 1 : solution(balls - 1, share -1) * balls / share;
        // n! / (n-m)! / m! 이기때문에
        // solution(balls - 1, share -1)을 share가 0이 될때까지 반복하면서
        // n에서 m까지 곱해주고 m에서 1까지는나눠준다.
    }
    
   
}
