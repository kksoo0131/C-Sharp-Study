using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = (1 + (k-1) * 2) % numbers.Length;
        return answer==0 ? numbers.Length : answer ;
        
        //나머지가 0일때가 
    }
}