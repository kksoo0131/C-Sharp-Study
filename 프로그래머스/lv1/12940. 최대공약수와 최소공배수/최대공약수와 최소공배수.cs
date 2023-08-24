using System;
public class Solution {
    public int[] solution(int n, int m) {
        int max = Math.Max(n,m);
        int gcd = GCD(max, (max == n ? m : n));
        return new int[] {gcd , n*m / gcd};
    }
    
    public int GCD(int a,int b){
        return (a % b == 0) ? b : GCD(b, a%b);
    }
}