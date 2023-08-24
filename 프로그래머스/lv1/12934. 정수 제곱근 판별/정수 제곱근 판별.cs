using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        double trysqrt = Math.Sqrt(n);

        return trysqrt == (int)trysqrt ? (long)Math.Pow(trysqrt+1, 2) : -1;
    }
}