using System;
public class Solution {
    public long solution(int a, int b) {
        long sum = 0;
        int max = Math.Max(a,b);
        int min = Math.Min(a,b);
        
        for (int i =min; i <=max; i++){
            sum += i;
        }
        
        return sum;
    }
}